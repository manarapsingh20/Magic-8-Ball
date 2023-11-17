using System;

namespace ManarapMagic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic 8 Ball");
            Console.WriteLine("Enter your question:");
            Console.ReadLine();

            Random random = new Random();
            int num = random.Next(0, 8);

            if (num == 0)
            {
                Console.WriteLine("Yes!!!");
                    }
            if (num == 1)
            {
                Console.WriteLine("No :(");
                    }
            if (num == 2)
            {
                Console.WriteLine("Signs point to yes");
            }
            if (num == 3)
            {
                Console.WriteLine("My sources say no");
            }
            if (num == 4)
            {
                Console.WriteLine("Stop it... get some help");
            } 
            if (num == 5)
            {
                Console.WriteLine("Why are you like this. SMH. No");
            }
            if (num == 6)
            {
                Console.WriteLine("You a W. Yes for you always");
            }
            if (num == 7)
            {
                Console.WriteLine("YESIRRRRRRRR");
            }
        }
    }
}
