using Newtonsoft.Json;


namespace BusinessObjects
{
    public partial class Customer
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }
    }
}
