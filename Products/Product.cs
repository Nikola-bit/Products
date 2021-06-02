using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
   public class Product
    {
       public string name { get; set; }
        public bool domestic { get; set; }
        public double price { get; set; }
        public string weight { get; set; }
        public string description { get; set; }
        public Product() { }
        public Product(string _name, bool _domestic, double _price, string _weight, string _description)
        {
            name = _name;
            domestic = _domestic;
            price = _price;
            weight = _weight;
            description = _description;
        }

        public void PrintDomestic()
        {
            Console.WriteLine("Name: {0}" +
                              "\nPrice: {1}" +
                             "\nweight: {2}"+
                              "\ndescription: {3}", name,  price, weight,description.Truncate(30));
            
        }
        public void PrintImported()
        {
            Console.WriteLine("Name: {0}" +
                              "\ndomestic: {1}" +
                              "\nPrice: {2}" +
                             "\nweight: {3}" +
                              "\ndescription: {4}", name, domestic, price, weight, description.Truncate(30));
         
        }
        
    }
    
}
