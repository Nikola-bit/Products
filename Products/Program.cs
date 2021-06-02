using System;
using System.Collections.Generic;
using System.Linq;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product("Tomato", true, 30.5, "150", "The species originated in western South America and Central America. The Nahuatl (the language used by the Aztecs) word tomatl gave rise to the Spanish word tomate, from which the English word tomato derived.");
            
            Product product2 = new Product("Apple" , true, 14.5, "0", "Apple trees are cultivated worldwide and are the most widely grown species in the genus Malus. The tree originated in Central Asia, where its wild ancestor, Malus sieversii, is still found today.");
            
            Product product3 = new Product()
            {
                name =  "Banana",
                domestic =  false,
                price = 22.0,
                description= "A banana is an elongated, edible fruit – botanically a berry – produced by several kinds of large herbaceous flowering plants in the genus Musa. In some countries, bananas used for cooking may be called plantains, distinguishing them from dessert bananas."
            };
            List<Product> products = new List<Product>()
            {
                product1,
                product2,
                product3
            };
            products.Sort(delegate (Product x, Product y) {
                return x.name.CompareTo(y.name);
            });
            List<Product> pr = products.Where(x => x.domestic == true).ToList();
            List<Product> pro = products.Where(x => x.domestic == false).ToList();
            decimal i, z,e,s;
            z = 0;
            s = 0;
            Console.WriteLine("Domestic Items");
            foreach (Product c in pr)
            {
                i = (decimal)c.price;
                z = z + i;
                if(c.weight == "0" || c.weight == "")
                {
                    c.weight = "N/A";
                }
                c.PrintDomestic();
                

            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Imported Items");
            foreach (Product c in pro)
            {
               
                e = (decimal)c.price;
                s = s + e;
                if (c.weight == "0" || c.weight == "")
                {
                    c.weight = "N/A";
                }
                c.PrintImported();


            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Domestic cost: $ {0}", z);
            Console.WriteLine("Imported cost: $ {0}", s);
            Console.WriteLine("Domestic count : {0}", pr.Count);
            Console.WriteLine("Imported count : {0}", pro.Count);
        }
    }
}

