using System.Collections.Generic;
using System;

namespace BraBetyg
{
    public class Chair : Seat
    {
        Random generator = new Random();

        public Chair()
        {
            seatAmount = generator.Next(2,10);

        }

        public void chairAmount ()
        {
            for (int i = 0; i < seatAmount; i++)
            {
                seatList.Add("Chair");
            }


        }
    }
}
