using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    //Generated using https://app.quicktype.io
    public partial class OrderList
    {
        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }

        public static OrderList FromJson(string json)
        {
            var orderList = JsonConvert.DeserializeObject<OrderList>(json);
            return orderList;
        }
    }
}
