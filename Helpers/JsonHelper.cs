
using Newtonsoft.Json;
using System;
using System.Net;

namespace InstagramPoll.Helpers
{
    public static class JsonHelper
    {
        public static T download_serialized_json_data<T>(string url) where T : new()
        {
            using(WebClient webClient = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as string
                try
                {
                    json_data = webClient.DownloadString(url);
                }
                catch (Exception)
                {
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }

        }
    }
}
