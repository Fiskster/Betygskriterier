using System;
using System.Collections.Generic;
namespace BraBetyg
{
    public class Food
    {
       
       public Dictionary<string,bool> burgers = new Dictionary<string, bool>();
       
        public string name; 

        public int calories; 

        public bool inStock; 


        public void BurgersAll()
        {
            CheeseBurger cheese = new CheeseBurger();
            Burger burger = new Burger();
            burgers.Add(cheese.name,cheese.inStock);
            burgers.Add(burger.name, burger.inStock);
            Console.WriteLine("cheeseburger in stock: " + burgers[cheese.name]);
            Console.WriteLine("burger in stock: " + burgers[burger.name]);

        }

    }
}