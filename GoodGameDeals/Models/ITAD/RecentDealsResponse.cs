﻿namespace GoodGameDeals.Models.ITAD {
    using Newtonsoft.Json;

    public partial class RecentDealsResponse {
        [JsonProperty("data")]
        public DataC Data { get; set; }

        [JsonProperty(".meta")]
        public MetaC Meta { get; set; }

        public class MetaC {
            [JsonProperty("currency")]
            public string Currency { get; set; }
        }

        public class DataC {
            [JsonProperty("count")]
            public long Count { get; set; }

            [JsonProperty("list")]
            public List[] List { get; set; }

            [JsonProperty("urls")]
            public PurpleUrls Urls { get; set; }
        }

        public class PurpleUrls {
            [JsonProperty("deals")]
            public string Deals { get; set; }
        }

        public class List {
            [JsonProperty("added")]
            public long Added { get; set; }

            [JsonProperty("drm")]
            public string[] Drm { get; set; }

            [JsonProperty("plain")]
            public string Plain { get; set; }

            [JsonProperty("price_cut")]
            public long PriceCut { get; set; }

            [JsonProperty("price_new")]
            public double PriceNew { get; set; }

            [JsonProperty("price_old")]
            public double PriceOld { get; set; }

            [JsonProperty("shop")]
            public Shop Shop { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("urls")]
            public FluffyUrls Urls { get; set; }
        }

        public class FluffyUrls {
            [JsonProperty("buy")]
            public string Buy { get; set; }

            [JsonProperty("game")]
            public string Game { get; set; }
        }

        public class Shop {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }

    public partial class RecentDealsResponse {
        public static RecentDealsResponse FromJson(string json) =>
            JsonConvert.DeserializeObject<RecentDealsResponse>(
                json,
                Converter.Settings);
    }

    public static partial class Serialize {
        public static string ToJson(this RecentDealsResponse self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);
    }
}