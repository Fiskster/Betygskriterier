using System;

namespace BraBetyg
{
    public class Sofa : Chair
    {


     public Sofa()
     {
         seatAmount = 8; 

     }

      public void sofaAmount()
      {

          for (int i = 0; i < seatAmount; i++)
            {
                sofaQueue.Enqueue("sofa");
            }

      }

    }
}
