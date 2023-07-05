// Program.cs Выполнил студент группы 34ИС Родионов Степан
using System;
using RodionovStepan34is.Library;

namespace RodionovStepan34is.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Name = "MAGA z";
            store.Address = "Ylica Bezztijih Fonarei";

            Product product1 = new Product { Name = "Product 1", Number = 5 };
            Product product2 = new Product { Name = "Product 2", Number = 3 };
            Product product3 = new Product { Name = "Product 3", Number = 7 };

            store.Products.Add(product1);
            store.Products.Add(product2);
            store.Products.Add(product3);

            store.ShowAll();

            Console.WriteLine("\nСортировка по номеру...");
            store.Products.Sort();
            store.ShowAll();

            Console.ReadLine();
        }
    }
}