using System.Collections.Generic;

namespace Wox.Plugin.YouTube.Models
{
    public class YouTubeSearchResult
    {
        public string Kind { get; set; }
        public string Etag { get; set; }
        public string NextPageToken { get; set; }
        public string RegionCode { get; set; }
        public PageInfo PageInfo { get; set; }
        public List<Item> Items { get; set; }
    }
}