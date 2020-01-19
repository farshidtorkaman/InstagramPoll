using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Logger;
using InstagramPoll.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstagramPoll.Controllers
{
    public class PollController : Controller
    {
        private static UserSessionData user;
        private static IInstaApi api;
        private static List<CommentViewModel> model;
        private static List<LikerViewModel> likeModel;
        private static string TextFileUrl = "Files/InformationAccount.txt";

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetMedia(string mediaUrl)
        {
            string[] lines = await System.IO.File.ReadAllLinesAsync(TextFileUrl);
            if (lines.Count() == 3)
            {
                user = new UserSessionData();
                user.UserName = lines[0];
                user.Password = lines[1];
                api = InstaApiBuilder.CreateBuilder()
                    .SetUser(user)
                    .UseLogger(new DebugLogger(LogLevel.Exceptions))
                    .Build();


                await api.LoadStateDataFromStringAsync(lines[2]);

                if (!api.IsUserAuthenticated)
                    return Json(new { success = false, message = "اکانت شما از برنامه قطع شده است لطفا دوباره وارد شوید." });

                var uri = new UriBuilder(mediaUrl).Uri;
                var mediaId = await api.MediaProcessor.GetMediaIdFromUrlAsync(uri);
                if (mediaId.Succeeded)
                {
                    IResult<InstaMedia> media = await api.MediaProcessor.GetMediaByIdAsync(mediaId.Value);

                    ReportViewModel report = new ReportViewModel()
                    {
                        CommentsCount = int.Parse(media.Value.CommentsCount),
                        LikesCount = media.Value.LikesCount,
                        MediaId = media.Value.Pk
                    };

                    return PartialView("_Report", report);
                }
                else
                {
                    return Json(new { success = false, message = mediaId.Info.Message });
                }
            }
            else
            {
                return Json(new { success = false, message = "اکانت شما از برنامه قطع شده است لطفا دوباره وارد شوید." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetLikes(string mediaId)
        {
            var likers = await api.MediaProcessor.GetMediaLikersAsync(mediaId);
            if (likers.Succeeded)
            {
                likeModel = likers.Value.Select(f => new LikerViewModel
                {
                    PK = f.Pk,
                    UserName = f.UserName
                }).ToList();
                return PartialView("_LikersResult", likeModel);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetComments(string mediaId)
        {
            var comments = await api.CommentProcessor.GetMediaCommentsAsync(mediaId, PaginationParameters.Empty);
            if (comments.Succeeded)
            {
                model = comments.Value.Comments.Select(f => new CommentViewModel
                {
                    PK = f.Pk,
                    UserName = f.User.UserName,
                    Text = f.Text
                }).ToList();
                return PartialView("_CommentsResult", model);
            }
            return View();
        }

        [HttpPost]
        public IActionResult RollForLike(int acceptablePersons = 1)
        {
            Random random = new Random();
            
            string results = "";
            acceptablePersons = acceptablePersons < likeModel.Count ? acceptablePersons : likeModel.Count;
            for (int i = 0; i < acceptablePersons; i++)
            {
                int index = random.Next(likeModel.Count);
                if (results.Contains(likeModel[index].UserName))
                    i--;
                else
                    results += i == 0 ? likeModel[index].UserName : ", " + likeModel[index].UserName;
            }
            return Json(new { result = results });
        }

        [HttpPost]
        public IActionResult Roll(string rightAnswer, bool repeatableAnswer, int? acceptableMentions, bool repeatableMention, int acceptablePersons = 1)
        {
            Random random = new Random();
            var comments = model;
            if (acceptableMentions != null)
            {
                List<string> usernames = new List<string>();
                if (repeatableMention)
                {
                    comments = comments.Where(f => f.Text.StartsWith("@") && f.Text.Split(' ').Count() == 1).ToList();
                    var users = comments.Select(f => f.UserName).Distinct().ToList();
                    foreach (var user in users)
                    {
                        int mentionedCount = comments.Where(f => f.UserName == user).Count();
                        if (mentionedCount >= acceptableMentions)
                            usernames.Add(user);
                    }
                    if (usernames.Count > 0)
                    {
                        string results = "";
                        acceptablePersons = acceptablePersons < usernames.Count ? acceptablePersons : usernames.Count;
                        for (int i = 0; i < acceptablePersons; i++)
                        {
                            int index = random.Next(usernames.Count);
                            if (results.Contains(usernames[index]))
                                i--;
                            else
                                results += i == 0 ? usernames[index] : ", " + usernames[index];

                        }
                        return Json(new { result = results });
                    }
                    else
                    {
                        return Json(new { result = "موردی یافت نشد" });
                    }
                }
                else
                {
                    var distinctComments = comments.Select(f => new { f.UserName, f.Text })
                                                .Distinct()
                                                .Where(f => f.Text.StartsWith("@") && f.Text.Split(' ').Count() == 1)
                                                .ToList();
                    var users = distinctComments.Select(f => f.UserName).Distinct().ToList();
                    foreach (var user in users)
                    {
                        int mentionedCount = distinctComments.Where(f => f.UserName == user).Count();
                        if (mentionedCount >= acceptableMentions)
                        {
                            usernames.Add(user);
                        }
                    }
                    if (usernames.Count > 0)
                    {
                        string results = "";
                        acceptablePersons = acceptablePersons < usernames.Count ? acceptablePersons : usernames.Count;
                        for (int i = 0; i < acceptablePersons; i++)
                        {
                            int index = random.Next(usernames.Count);
                            if (results.Contains(usernames[index]))
                            {
                                i--;
                            }
                            else
                            {
                                results += i == 0 ? usernames[index] : ", " + usernames[index];
                            }

                        }
                        return Json(new { result = results });
                    }
                    else
                    {
                        return Json(new { result = "موردی یافت نشد" });
                    }
                }
            }
            else
            {
                if (repeatableAnswer)
                {
                    comments = comments.Where(f => f.Text == rightAnswer).ToList();
                }
                else
                {
                    var distinctComments = comments.Select(f => new { f.UserName, f.Text })
                                    .Distinct()
                                    .Where(f => f.Text == rightAnswer)
                                    .ToList();

                    if (distinctComments.Count > 0)
                    {
                        string results = "";
                        acceptablePersons = acceptablePersons < distinctComments.Count ? acceptablePersons : distinctComments.Count;
                        for (int i = 0; i < acceptablePersons; i++)
                        {
                            int index = random.Next(comments.Count);
                            if (results.Contains(comments[index].UserName))
                            {
                                i--;
                            }
                            else
                            {
                                results += i == 0 ? comments[index].UserName : ", " + comments[index].UserName;
                            }

                        }
                        return Json(new { result = results });
                    }
                    else
                    {
                        return Json(new { result = "موردی یافت نشد" });
                    }

                }
                if (comments.Count > 0)
                {
                    string results = "";
                    int distinctCount = comments.Select(f => f.UserName).Distinct().Count();
                    acceptablePersons = acceptablePersons < distinctCount ? acceptablePersons : distinctCount;
                    for (int i = 0; i < acceptablePersons; i++)
                    {
                        int index = random.Next(comments.Count);
                        if (results.Contains(comments[index].UserName))
                        {
                            i--;
                        }
                        else
                        {
                            results += i == 0 ? comments[index].UserName : ", " + comments[index].UserName;
                        }

                    }
                    return Json(new { result = results });
                }
                else
                {
                    return Json(new { result = "موردی یافت نشد" });
                }
            }
        }
    }
}