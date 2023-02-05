using PizzasAccounting.Accounting.ProductOrders;
using PizzasAccounting.Enums.AccoutingEnums;
using PizzasAccounting.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Accounting
{
    public class ProductPizzaOrder : AbstractProductOrder
    {
        private Pizza PizzaItem { get; set; }
        private PizzaSizesEnum Size { get; set; }
        private PizzaDoughEnum Dough { get; set; }

        public ProductPizzaOrder(int id, int orderID, Pizza pizzaItem, byte quantity, PizzaSizesEnum size, PizzaDoughEnum dough) : base(id, orderID, quantity)
        {
            PizzaItem = pizzaItem;
            Size = size;
            Dough = dough;
        }
        public override float CostCalculation()
        {
            float price = PizzaItem.BaseСost;

            switch (Size)
            {
                case PizzaSizesEnum.Small:
                    price += 50;
                    break;
                case PizzaSizesEnum.Medium:
                    price += 150;
                    break;
                case PizzaSizesEnum.Large:
                    price += 250;
                    break;
            }

            switch (Dough)
            {
                case PizzaDoughEnum.Traditional:
                    price += 50;
                    break;
                case PizzaDoughEnum.Thin:
                    price += 100;
                    break;
            }

            return price * Quantity;
        }
    }
}
