using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Delivery
{
    public class RestaurantDelivery : AbstractDelivery
    {
        public override string Name => "Самовывоз из ресторана";
        public override float DeliveryPrice { get => 0; }
        public string RestaurantAddress { get; set; }
        public RestaurantDelivery(DateTime orderDateTime, string restaurantAddress) : base(orderDateTime)
        {
            RestaurantAddress = restaurantAddress;
        }
    }
}
