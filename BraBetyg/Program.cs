using System;

namespace BraBetyg
{
    class Program
    {
        static void Main(string[] args)
        {
            Food foods = new Food();
            Seat seats = new Seat();

            foods.BurgersAll();
            seats.allSeats();
            Console.ReadLine();
                        
        }
    }
}
