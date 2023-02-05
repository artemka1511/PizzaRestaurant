using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Accounting.ProductOrders
{
    public abstract class AbstractProductOrder
    {
        private int ID { get; set; }
        private int OrderID { get; set; }
        protected byte Quantity { get; set; }
        public abstract float CostCalculation();

        public AbstractProductOrder(int id, int orderID, byte quantity)
        {
            ID = id;
            OrderID = orderID;
            Quantity = quantity;
        }
    }
}
