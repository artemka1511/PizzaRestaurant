using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Delivery
{
    public class HomeDelivery: AbstractDelivery
    {
        public override string Name => "Доставка на дом";

        private const int HIGH_LOAD = 300;
        private const int STANDART_LOAD = 150;
        string HomeAddress { get; set; }
        
        public override float DeliveryPrice
        {
            get
            {
                if (OrderDateTime.Hour > 17 && OrderDateTime.Hour < 22)
                {
                    return HIGH_LOAD;
                }
                else
                {
                    return STANDART_LOAD;
                }
            }
        }
        public HomeDelivery(DateTime orderDateTime, string homeAddress) : base(orderDateTime)
        {
            HomeAddress = homeAddress;
        }
    }
}
