using System;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            

            for(int i = 0; i < 10; i++)
            {
                int value = rand.Next(0, 100);
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
