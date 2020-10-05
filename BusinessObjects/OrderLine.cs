using Newtonsoft.Json;


namespace BusinessObjects
{
    public partial class OrderLine
    {
        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("cost")]
        public long Cost { get; set; }
    }
}
