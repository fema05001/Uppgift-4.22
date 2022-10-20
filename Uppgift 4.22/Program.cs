using System;
namespace Uppgift_4_22
{
    class program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 200;
            int z = 1000;
            while (z < 1400)
            {
                while (x <= 30)
                {
                    Console.WriteLine(x);
                    x++;
                }
                
                while (y >=180)
                {
                    
                    Console.WriteLine(y);
                    y--;
                }
                while (z <= 1400)
                {
                    Console.WriteLine(z);
                    z = z + 50;
                }
            }
        }
    }
}