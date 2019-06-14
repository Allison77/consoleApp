﻿using System;

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
            // test was just created as a test and can be removed.  Console.Readline() is that "action" of reading the input
            var lETTERSELECTED = Console.ReadLine();

            if (lETTERSELECTED == "a")
            {
                Console.WriteLine("You've selected numbers 1-10");
                //test
            }

            else if (lETTERSELECTED == "b")
            {
                Console.WriteLine("You've selected numbers 10-20");
            }

            else if (lETTERSELECTED == "c")
            {
                Console.WriteLine("You've selected numbers 20-30");
            }

            else if (lETTERSELECTED == "d")
            {
                Console.WriteLine("You've selected numbers 30-40");
            }
            // variables (like var test above) can be named almost anything.  Try to make them as descriptive as possible.  Use camel casing when naming.
            // This simply mean capitalizing all first letter of words except the first so "I am the greatest" would be "iAmTheGreatest"

            // ie:  var (fill in a better name here for a placeholder that holds the value of the input from console.readline)
            //then set it equal to the readlinefunction
            //BUT, that only brings in the EXACT value INCLUDING CAPITALS
            // create another variable and name it something similar to the first with the addition of letting you know it will be the value in lower case
            // then set it equal to the other variable with the lowercase method                 


            String variable = lETTERSELECTED.ToLower();
            Console.WriteLine($"Lowercase: {variable}");

            if (lETTERSELECTED != "a" && lETTERSELECTED != "b" && lETTERSELECTED != "c" && lETTERSELECTED != "d")
            {
                Console.WriteLine("Please select a valid option");
            }

        }
    }
}