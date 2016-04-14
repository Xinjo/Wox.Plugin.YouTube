using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using Wox.Plugin.YouTube.Models;

namespace Wox.Plugin.YouTube
{
    public class YouTubePlugin : IPlugin
    {
        private readonly string _apiKey = "";

        public List<Result> Query(Query query)
        {
            var tempResults = new List<KeyValuePair<Item, string>>();

            using (var webClient = new WebClient())
            {
                var json =
                    webClient.DownloadString(
                        "https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=20&q=" +
                        HttpUtility.UrlEncodeUnicode(query.Search) + "&key=" + _apiKey);

                var result = JsonConvert.DeserializeObject<YouTubeSearchResult>(json);

                tempResults.AddRange(from i in result.Items where i.Id.VideoId != null select new KeyValuePair<Item, string>(i, ""));
            }

            return tempResults.Select(result => new Result
            {
                Title = result.Key.Snippet.Title, SubTitle = result.Key.Snippet.ChannelTitle, IcoPath = "youtube.png", Action = e =>
                {
                    Process.Start("https://www.youtube.com/watch?v=" + result.Key.Id.VideoId);
                    return true;
                }
            }).ToList();
        }

        public void Init(PluginInitContext context)
        {
        }
    }
}