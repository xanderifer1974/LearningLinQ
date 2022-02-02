using LearningLinQ.Entities;
using System;
using System.Collections.Generic;

namespace LearningLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Alicate", 30.00));
            list.Add(new Product("Beliche", 400.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            /*Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());*/ //Utilizando lambda
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); //Delegate -> referência para uma função.

            foreach (Product p in list)
            {
                Console.WriteLine(p);

            }
            Console.ReadKey();

        }

        //static int CompareProduct(Product p1,Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}
