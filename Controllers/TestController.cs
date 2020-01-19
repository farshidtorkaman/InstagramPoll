using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using InstagramPoll.Helpers;
using InstaSharp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;

using InstaSharp.Models.Responses;
using System.Configuration;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace InstagramPoll.Controllers
{
    public class TestController : Controller
    {
        InstagramConfig config = new InstagramConfig("75649c4f3a28422dae507dddf35e1505", "087ba8dabeea40c09139379527c8f20e ", "http://localhost:52899/Test/GetUser", "");
        public IActionResult Index(string mediaUrl)
        {
            return View();
        }

        public IActionResult GetUser(string code)
        {
            ViewData["Code"] = code;

            string URI = "https://api.instagram.com/oauth/access_token";
            string myParameters = "client_id=c1c30f885e234aa1981038bf1440ccdf&client_secret=e166ce688b5e4b4fab08f6d2768eeeee&grant_type=authorization_code&redirect_uri=http://localhost:52899/Test/GetUser&code=" + code;

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URI, myParameters);
                JObject json = JObject.Parse(HtmlResult);
                UserInformation userInformation = JsonConvert.DeserializeObject<UserInformation>(HtmlResult);

                //string url = $"https://api.instagram.com/v1/users/self/media/recent?access_token={userInformation.access_token}";
                //string media = wc.DownloadString(url);
                string url = $"https://api.instagram.com/v1/media/2064427319182858770_14690266919/comments?access_token={userInformation.access_token}";
                JObject mediaObject = JObject.Parse(wc.DownloadString(url));
                


            }

            return View();
        }

    }
}