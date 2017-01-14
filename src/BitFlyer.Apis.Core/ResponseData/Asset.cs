﻿using Newtonsoft.Json;

namespace BitFlyer.Apis
{
    public struct Asset
    {
        [JsonProperty("currency_code")]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("available")]
        public double? Available { get; set; }
    }
}
