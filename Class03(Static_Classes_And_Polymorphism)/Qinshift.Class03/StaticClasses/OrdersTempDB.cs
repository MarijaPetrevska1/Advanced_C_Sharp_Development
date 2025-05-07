using StaticClasses.Entities.Enums;
using StaticClasses.Entities.Helpers;
using StaticClasses.Entities.Models;
using System.Net.NetworkInformation;

namespace StaticClasses
{
    public static class OrdersTempDB
    {
        private static int orderIdCounter = 5;
        public static List<User> Users;
        public static List<Order> Orders;

        static OrdersTempDB()
        {
            ConsoleHelper.WriteInColor("Hello from OrdersTempDb", ConsoleColor.DarkMagenta);

            Orders = new List<Order>()
            {
                new Order(1, "book of books", "Best book ever", OrderStatus.Delivered),
                new Order(2, "keyboard", "Mechanical", OrderStatus.DeliveryInProgress),
                new Order(3, "Shoes", "Waterproof", OrderStatus.DeliveryInProgress),
                new Order(4, "Set of Pens", "Ordinary pens", OrderStatus.Processing),
                new Order(5, "sticky Notes", "Stickiest notes in the world", OrderStatus.NotDelivered)
            };
            Users = new List<User>()
            {
                new User(1, "Bob22", "Bob St. 44"),
                new User(2, "JillCoolCat", "Wayne St. 109a")
            };
            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[0].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);
        }

        public static void ListUsers()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Users[i].UserName}");
            }
        }

        public static void InsertOrder(int userId, Order order)
        {
            order.Id = ++orderIdCounter;
            Orders.Add(order);
            Users.Single(u => u.Id == userId).Orders.Add(order);
            ConsoleHelper.WriteInColor("Order successfully created!", ConsoleColor.Green);
        }
    }

}