using System;

namespace WhileLoop
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Jun Anthony";
            string password = "0123456a";

;            string pass = "";

            while (pass != password)
            {
                Console.Write("Please enter the right password: ");
                pass = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {name}");

            Console.ReadKey();
        }
    }
}