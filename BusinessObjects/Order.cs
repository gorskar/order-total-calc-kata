using Newtonsoft.Json;


namespace BusinessObjects
{
    public partial class Order
    {
        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("orderLines")]
        public OrderLine[] OrderLines { get; set; }

        public static Order FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Order>(json);
        }
    }
}
