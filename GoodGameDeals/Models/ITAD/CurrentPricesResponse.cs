﻿// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = CurrentPricesResponse.FromJson(jsonString);
//

namespace GoodGameDeals.Models.ITAD {
    using Newtonsoft.Json;

    public partial class CurrentPricesResponse {
        [JsonProperty("data")]
        public DataC Data { get; set; }

        [JsonProperty(".meta")]
        public MetaC Meta { get; set; }

        public class MetaC {
            [JsonProperty("currency")]
            public string Currency { get; set; }
        }


        [JsonConverter(typeof(PlainConverter))]
        public class DataC {
            [JsonProperty("plain")]
            public Plain
                Plain { get; set; }

        }

        public class Plain {
            [JsonProperty("list")]
            public List[] List { get; set; }

            [JsonProperty("urls")]
            public Urls Urls { get; set; }
        }


        public class Urls {
            [JsonProperty("game")]
            public string Game { get; set; }
        }

        public class List {
            [JsonProperty("drm")]
            public string[] Drm { get; set; }

            [JsonProperty("price_cut")]
            public long PriceCut { get; set; }

            [JsonProperty("price_new")]
            public double PriceNew { get; set; }

            [JsonProperty("price_old")]
            public double PriceOld { get; set; }

            [JsonProperty("shop")]
            public Shop Shop { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }

        public class Shop {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }

    public partial class CurrentPricesResponse {
        public static CurrentPricesResponse FromJson(string json) =>
            JsonConvert.DeserializeObject<CurrentPricesResponse>(
                json,
                Converter.Settings);
    }

    public static partial class Serialize {
        public static string ToJson(this CurrentPricesResponse self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);
    }
}