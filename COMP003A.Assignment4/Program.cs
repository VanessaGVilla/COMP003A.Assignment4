/*Author: Vanessa Garcia
 * Course: Comp - 003A - L01
 * Purpose: Assignment 4 Looping Statements
*/


namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Loop Section");
            Console.WriteLine("Right Triangle");

            Console.WriteLine("Enter a positive whole number:");
            int limit;

            while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 0)
            {


                Console.WriteLine("Invalid input.Please enter a positive whole number:");
            }

            string output = "#";

            Console.WriteLine(" The limit is: " + limit);
            Console.WriteLine("The output is: " + output);
        }
    }
}









            Console.WriteLine("****************************************");
            Console.WriteLine("Friends");
            Console.WriteLine("Array");

            string[] friends = new string[] 
            { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);


                Console.WriteLine("******************************************");
                Console.WriteLine("Do While Loop");
                Console.WriteLine("Counting by 5");

            {
                int Counter = 0;

                do
                {
                    Console.WriteLine(Counter);
                    Counter += 5;
                } while (Counter <= 50);
            }




        }
    }
}