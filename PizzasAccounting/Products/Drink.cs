using PizzasAccounting.Enums;
using PizzasAccounting.Enums.ProductsEnums.DrinkEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Products
{
    public class Drink : AbstractProduct
    {
        DrinkTypesEnum DrinkType { get; set; }

        public Drink(int id, string name, DrinkTypesEnum drinkType, float baseCost) : base(id, name, baseCost)
        {
            DrinkType = drinkType;
        }
    }
}
