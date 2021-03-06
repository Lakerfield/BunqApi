﻿using Newtonsoft.Json;

namespace Sycade.BunqApi.Model
{
    public class Address : IBunqEntity
    {
        [JsonProperty("street")]
        public string Street { get; set; }
        [JsonProperty("house_number")]
        public string HouseNumber { get; set; }
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("province")]
        public string Province { get; set; }
    }
}
