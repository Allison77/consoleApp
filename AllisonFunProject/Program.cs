using System;

namespace AllisonFunProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("(a) numbers 1-10");
            Console.WriteLine("(b) numbers 10-20");
            Console.WriteLine("(c) numbers 20-30");
            Console.WriteLine("(d) numbers 30-40");

            var test = Console.ReadLine();

            if (test == "a")
            {
                Console.WriteLine("You've selected numbers 1-10");
            }

            else if (test == "b")
            {
                Console.WriteLine("You've selected numbers 10-20");
            }

            else if (test == "c")
            {
                Console.WriteLine("You've selected numbers 20-30");
            }

            else if (test == "d")
            {
                Console.WriteLine("You've selected numbers 30-40");
            }

            String variable = test.ToLower();
            Console.WriteLine($"Lowercase: {variable}");
        }
    }
   

    }