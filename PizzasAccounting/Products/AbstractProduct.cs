using PizzasAccounting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Products
{
    public abstract class AbstractProduct
    {
        public int ID { get; set; }  // Используем ID, который мы якобы получаем из БД
        public string Name { get; set; }
        public float BaseСost { get; set; }

        public AbstractProduct(int id, string name, float baseCost)
        {
            ID = id;
            Name = name;
            BaseСost = baseCost;
        }
    }


}
