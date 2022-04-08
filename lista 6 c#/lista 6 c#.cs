using System;

namespace Aula6VSC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            
            Console.WriteLine("Tabuada: ");
            for (x = 0 ; x <= 10 ; x++)
            {
                for (int y = 0; y <= 10; y++)
                {
                    Console.WriteLine(x + "x" + y + "=" + x * y);

                }
            }

            
        }
    }
}
