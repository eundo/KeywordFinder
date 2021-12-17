using Newtonsoft.Json;
using System.Collections.Generic;

namespace KeywordFinder
{
    public class ChromeBookmark
    {
        public class Children
        {
            [JsonProperty("date_added")]
            public string dateAdded;
            public string guid;
            public string id;
            public string name;
            public string type;
            public string url;
            public List<Children> children;

                
        }

        public class Bookmark
        {
            [JsonProperty("children")]
            public List<Children> childrens;

            [JsonProperty("date_added")]
            public string dateAdded;

            [JsonProperty("date_modified")]
            public string dateModified;
            public string guid;
            public string id;
            public string name;
            public string type;
        }

        public class Roots
        {
            [JsonProperty("bookmark_bar")]
            public Bookmark bookmarkBar;
            public Bookmark other;
            public Bookmark synced;
        }

        public string checksum;
        public Roots roots;
        public int version;
    }
}
