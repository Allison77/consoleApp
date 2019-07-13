using System;

namespace AllisonFunProject
{
    public class Program
    {
        static public void Main()
        {
            Console.WriteLine("Hello World");
            var whatever = new TestThing();
            whatever.pleaseSelectAnOption();

            var letterSelected = Console.ReadLine();

            if (letterSelected == "a" || letterSelected == "A")
            {
                Console.WriteLine("You've selected numbers 1-10");
                Console.WriteLine("Please pick a number between 1 and 10");
                string input = Console.ReadLine();
                int number;
                Int32.TryParse(input, out number);
                Console.WriteLine("You've chosen " + input);

            }


            else if (letterSelected == "b")
            {
                Console.WriteLine("You've selected numbers 10-20");
                Console.WriteLine("Please pick a nubmer between 10 and 20");
                string input = Console.ReadLine();
                int number;
                Int32.TryParse(input, out number);
                Console.WriteLine("You've chosen " + input);
            }

            else if (letterSelected == "c")
            {
                Console.WriteLine("You've selected numbers 20-30");
                Console.WriteLine("Please pick a number between 20 and 30");
                string input = Console.ReadLine();
                int number;
                Int32.TryParse(input, out number);
                Console.WriteLine("You've chosen " + input);
            }

            else if (letterSelected == "d")
            {
                Console.WriteLine("You've selected numbers 30-40");
                Console.WriteLine("Please pick a number between 30 and 40");
                string input = Console.ReadLine();
                int number;
                Int32.TryParse(input, out number);
                Console.WriteLine("You've chosen " + input);
            }

            else
            {
                Console.WriteLine("Please select a valid option");
                whatever.pleaseSelectAnOption();
            }
            {

                Console.WriteLine("Would you like to see the results of this number compared to another with different matehmatical expressions? (yes/no)");
                var answerEntered = Console.ReadLine();                                                             
                if ((answerEntered == "no") || (answerEntered == "n") || (answerEntered == "N") || (answerEntered == "NO"))

                {                     
                        Console.WriteLine("Ok, have a good day!");
                        Console.WriteLine($"Hello World");
                        whatever.pleaseSelectAnOption();
                                 
                }
               if (answerEntered == "yes")
                {
                    Console.WriteLine("Please pick another number between 1 and 100");
                    String input = Console.ReadLine();
                    int number;
                    Int32.TryParse(input, out number);
                    Console.WriteLine ("You've chosen "+ number);
                }

            }


            // create another variable and name it something similar to the first with the addition of letting you know it will be the value in lower case
            // then set it equal to the other variable with the lowercase method               


            //String variable = letterSelected.ToLower();
            //Console.WriteLine($"Lowercase: {variable}");  //I have messed this code up.  How do I get it to change the capital letter to lowercase? 
            //I thought it was working previously but probably not.

            //if (letterSelected != "a" && letterSelected != "b" && letterSelected != "c" && letterSelected != "d")
            //{
            //    Console.WriteLine("Please select a valid option");
            //}





        }



    }



    public class TestThing
    {
        public int ItAddsStuff(int a, int b)
        {
            return a + b; 
        }

        public void pleaseSelectAnOption()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("(a) numbers 1-10");
            Console.WriteLine("(b) numbers 10-20");
            Console.WriteLine("(c) numbers 20-30");
            Console.WriteLine("(d) numbers 30-40");
        }


        ///////////////////////////////////////////////////

        public int ForFunMethod(int first, int second)
        {
            return first - second;
        }










        ///////////////////////////////////////////////////////////

    }

    class program
    {
        static void Subtract(double first, double second)
        {
            Console.WriteLine(first - second);
        }
    }
}