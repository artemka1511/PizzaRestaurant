using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Delivery
{
    public abstract class AbstractDelivery
    {
        public abstract string Name { get; }
        public abstract float DeliveryPrice { get; }
        protected DateTime OrderDateTime { get; set; }
        public AbstractDelivery(DateTime orderDateTime)
        {
            OrderDateTime = orderDateTime;
        }
    }
}
