using PizzasAccounting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Products
{
    public class Pizza : AbstractProduct
    {
        bool IsSpicy { get; }
        bool IsVegetarian { get; }
        string Description { get; }

        public Pizza(int id, string name, string description, bool isSpicy, bool isVegetarian, float baseCost) : base(id, name, baseCost)
        {
            IsSpicy = isSpicy;
            IsVegetarian = isVegetarian;
            Description = description;
        }
    }
}
