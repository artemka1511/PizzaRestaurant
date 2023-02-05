using PizzasAccounting.Accounting;
using PizzasAccounting.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasAccounting.Transport_Department
{
    static class TransportDepartment<T> where T : Order<HomeDelivery>
    {
        static List<T> CurrentOrderList = new List<T>();
        public static void AddOrder(T order)
        {
            Console.WriteLine("Заказ принят транспортным отделом");
            CurrentOrderList.Add(order);
        }

        public static void Processing()
        {
            Console.WriteLine("Происходит обработка заказа");
        }

        public static void SendOrder(T order)
        {
            Console.WriteLine("Заказ успешно отправлен");
            CurrentOrderList.Remove(order);
        }
    }
}
