using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate {
    class Program {
        static void Main(string[] args) {
            
            List<Product> list = new List<Product>();
            List<Product> tvList = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("HD Case", 80.90));

            Console.Write(">> ");
            string nome = Console.ReadLine();

            tvList = list.FindAll(x => x.Name.Equals(nome));

            foreach (Product product in tvList) {
                Console.WriteLine(product);
            }
           
            Console.ReadLine();
        }

    }
}
