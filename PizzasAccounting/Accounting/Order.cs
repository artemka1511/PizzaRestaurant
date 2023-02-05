using PizzasAccounting.Accounting.ProductOrders;
using PizzasAccounting.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Accounting
{
    public class Order<TDelivery> where TDelivery: AbstractDelivery
    {
        private int ID { get; set; }
        private TDelivery Delivery { get; set; }
        private float Cost { get; set; }

        List<AbstractProductOrder> ProductOrders = new List<AbstractProductOrder>();

        public Order(int number, TDelivery delivery)
        {
            ID = number;
            Delivery = delivery;
            Console.WriteLine($"Ваш заказ N: {ID}");
        }

        public void AddItem(AbstractProductOrder productOrder)
        {
            ProductOrders.Add(productOrder);
            CheckCost();
        }

        public void RemoveItem(AbstractProductOrder productOrder)
        {
            ProductOrders.Remove(productOrder);
            CheckCost();
        }

        private void CheckCost()
        {
            Cost = 0;

            foreach (var item in ProductOrders)
            {
                Cost += item.CostCalculation();
            }

            Cost += Delivery.DeliveryPrice;

            DisplayCost();
        }

        private void DisplayCost()
        {
            Console.WriteLine($"Стоимость заказа изменилась и составляет: {Cost}");
        }
    }
}
