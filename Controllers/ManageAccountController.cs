using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using Microsoft.AspNetCore.Mvc;

namespace InstagramPoll.Controllers
{
    public class ManageAccountController : Controller
    {
        private static string TextFileUrl = "Files/InformationAccount.txt";
        private static UserSessionData user;
        private static IInstaApi api;

        public IActionResult Index()
        {
            string[] text = System.IO.File.ReadAllLines(TextFileUrl);
            if(text.Count() == 3)
            {
                ViewData["Username"] = text[0];
                ViewData["Password"] = text[1];
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
            if(username == null || password == null)
            {
                ViewData["ErrorMessage"] = "هر دو فیلد باید پر شود";
                ViewData["Username"] = username;
                ViewData["Password"] = password;
                return View();
            }

            user = new UserSessionData();
            user.UserName = username;
            user.Password = password;
            api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                .Build();


            var result = await api.LoginAsync();
            if (result.Succeeded)
            {
                string state = await api.GetStateDataAsStringAsync();
                await System.IO.File.WriteAllTextAsync(TextFileUrl, string.Empty);
                string[] lines = { username, password, state };
                await System.IO.File.WriteAllLinesAsync(TextFileUrl, lines);
                return RedirectToAction("Index", "Poll");
            }
            else
            {
                switch (result.Value)
                {
                    case InstaLoginResult.InvalidUser:
                        ViewData["ErrorMessage"] = "نام کاربری نامعتبر است";
                        break;
                    case InstaLoginResult.BadPassword:
                        ViewData["ErrorMessage"] = "رمز عبور اشتباه است";
                        break;
                    case InstaLoginResult.Exception:
                        ViewData["ErrorMessage"] = result.Info?.Message;
                        break;
                    case InstaLoginResult.LimitError:
                        ViewData["ErrorMessage"] = "ارور دسترسی (باید 10 دقیقه صبر کنید)";
                        break;
                    case InstaLoginResult.ChallengeRequired:
                        return RedirectToAction("ChallengeRequired");
                    case InstaLoginResult.TwoFactorRequired:
                        return RedirectToAction("TwoFactor");
                }
            }
            ViewData["Username"] = username;
            ViewData["Password"] = password;
            return View();
        }

        public async Task<IActionResult> ChallengeRequired()
        {
            IResult<InstaChallengeRequireVerifyMethod> challenge = null;
            challenge = await api.GetChallengeRequireVerifyMethodAsync();
            ViewBag.PhoneNumberAvailable = false;
            ViewBag.EmailAvailable = false;
            if (challenge.Succeeded)
            {
                if (challenge.Value.StepData != null)
                {
                    if (!string.IsNullOrEmpty(challenge.Value.StepData.PhoneNumber))
                    {
                        ViewBag.PhoneNumberAvailable = true;
                        ViewBag.PhoneNumber = challenge.Value.StepData.PhoneNumber;

                    }
                    if (!string.IsNullOrEmpty(challenge.Value.StepData.Email))
                    {
                        ViewBag.EmailAvailable = true;
                        ViewBag.Email = challenge.Value.StepData.Email;
                    }
                }
            }
            else
                ViewData["ErrorMessage"] = challenge.Info.Message;


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChallengeRequired(string sendCodeMethod)
        {
            bool isEmail = false;
            if (sendCodeMethod == "email")
                isEmail = true;

            if (isEmail)
            {
                var email = await api.RequestVerifyCodeToEmailForChallengeRequireAsync();
                if (email.Succeeded)
                {
                    ViewData["Message"] = $"کد تاییدیه به این ایمیل ارسال شد : {email.Value.StepData.ContactPoint}";
                    return RedirectToAction("VerifyChallenge");
                }
                else
                    ViewData["ErrorMessage"] = email.Info.Message;
            }
            else
            {
                var phoneNumber = await api.RequestVerifyCodeToSMSForChallengeRequireAsync();
                if (phoneNumber.Succeeded)
                {
                    ViewData["Message"] = $"کد تاییدیه به این شماره تلفن ارسال شد : {phoneNumber.Value.StepData.ContactPoint}";
                    return RedirectToAction("VerifyChallenge");
                }
                else
                    ViewData["ErrorMessage"] = phoneNumber.Info.Message;
            }

            return View();
        }

        public IActionResult VerifyChallenge()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VerifyChallenge(string code)
        {
            code = code.Trim();
            code = code.Replace(" ", "");
            var regex = new Regex(@"^-*[0-9,\.]+$");
            if (!regex.IsMatch(code))
            {
                ViewData["ErrorMessage"] = "لطفا فقط عدد وارد نمایید";
                return View();
            }
            if (code.Length != 6)
            {
                ViewData["ErrorMessage"] = "کد تاییدیه باید 6 رقم باشد";
                return View();
            }
            var verify = await api.VerifyCodeForChallengeRequireAsync(code);
            if (verify.Succeeded)
            {
                string state = await api.GetStateDataAsStringAsync();
                await System.IO.File.WriteAllTextAsync(TextFileUrl, string.Empty);
                string[] lines = { user.UserName, user.Password, state };
                await System.IO.File.WriteAllLinesAsync(TextFileUrl, lines);
                return RedirectToAction("Index", "Poll");

            }
            else
            {
                if (verify.Value == InstaLoginResult.TwoFactorRequired)
                {
                    return RedirectToAction("TwoFactor");
                }
            }
            ViewData["ErrorMessage"] = verify.Info.Message;
            return View();
        }
    }
}