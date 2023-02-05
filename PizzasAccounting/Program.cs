using PizzasAccounting.Products;
using System;
using PizzasAccounting.Enums.ProductsEnums.DrinkEnums;
using PizzasAccounting.Accounting;
using PizzasAccounting.Delivery;
using PizzasAccounting.Transport_Department;

namespace PizzasAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём меню пицца-ресторана:

            var pizzaPepperoni = new Pizza(1, "Пепперони",
                "Американская классика с пикантной пепперони, Моцареллой и фирменным томатным соусом", true, false, 350);

            var pizzaVegan = new Pizza(2, "Вегетарианская",
                "Лёгкая пицца с фирменным томатным соусом, Моцареллой, сладким перцем, шампиньонами, маслинами, луком и сочными томатами", false, true, 400);

            var pizzaFourCheeses = new Pizza(3, "Четыре Сыра",
                "Традиционное сочетание сыров: Моцарелла, мягкий молодой сыр, сыр с голубой плесенью, Чеддер, фирменный томатный соус и орегано", false, false, 500);

            var teaBlack = new Drink(1, "Черный чай", DrinkTypesEnum.Tea, 25);

            var coffeeCappuccino = new Drink(2, "Капучино", DrinkTypesEnum.Coffee, 150);

            var sodaCola = new Drink(3, "Coca Cola", DrinkTypesEnum.Soda, 50);

            // Когда клиент заходит в приложение, то создаётся объект класса "Заказ". Также в заказе выбирается тип доставки

            var firstOrder = new Order<HomeDelivery>(25, new HomeDelivery(DateTime.Now, "улица Ленина 43 кв 25"));

            // При добавлении товара в корзину создаётся наследник объекта AbstractProductOrder. Клиенту отобразится стоимость заказа

            firstOrder.AddItem(new ProductPizzaOrder(61, 25, pizzaPepperoni, 1, Enums.AccoutingEnums.PizzaSizesEnum.Large, Enums.AccoutingEnums.PizzaDoughEnum.Traditional));
            firstOrder.AddItem(new ProductPizzaOrder(62, 25, pizzaVegan, 1, Enums.AccoutingEnums.PizzaSizesEnum.Medium, Enums.AccoutingEnums.PizzaDoughEnum.Thin));
            firstOrder.AddItem(new ProductDrinkOrder(63, 25, sodaCola, 3, DrinkSizesEnum.Large));

            // Передаём заказ в транспортный отдел

            TransportDepartment<Order<HomeDelivery>>.AddOrder(firstOrder);
            TransportDepartment<Order<HomeDelivery>>.Processing();
            TransportDepartment<Order<HomeDelivery>>.SendOrder(firstOrder);
        }
    }
}
