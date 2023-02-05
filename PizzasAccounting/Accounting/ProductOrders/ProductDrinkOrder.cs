using PizzasAccounting.Enums.ProductsEnums.DrinkEnums;
using PizzasAccounting.Accounting.ProductOrders;
using PizzasAccounting.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Accounting
{
    public class ProductDrinkOrder : AbstractProductOrder
    {
        private Drink DrinkItem { get; set; }
        private DrinkSizesEnum Size { get; set; }

        public ProductDrinkOrder(int id, int orderID, Drink drinkItem, byte quantity, DrinkSizesEnum size) : base (id, orderID, quantity)
        {
            DrinkItem = drinkItem;
            Size = size;
        }

        public override float CostCalculation()
        {
            float price = DrinkItem.BaseСost;

            switch (Size)
            {
                case DrinkSizesEnum.Small:
                    price += 50;
                    break;
                case DrinkSizesEnum.Medium:
                    price += 100;
                    break;
                case DrinkSizesEnum.Large:
                    price += 125;
                    break;
            }

            return price * Quantity;
        }
    }
}
