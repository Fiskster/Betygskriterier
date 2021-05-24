using System;
using System.Collections.Generic;

namespace BraBetyg
{
    public class Seat
    {
        public int seatAmount;


        public static List<string> seatList = new List<string>();

        public static Queue<string> sofaQueue = new Queue<string>();

        public void allSeats()
        {
            Chair chairs = new Chair();
            chairs.chairAmount();
            Sofa sofas = new Sofa();
            sofas.sofaAmount();

            Console.WriteLine(seatList.Count + " chairs are free.");
             Console.WriteLine(sofaQueue.Count + " sofas are free.");


        }


    }
}
