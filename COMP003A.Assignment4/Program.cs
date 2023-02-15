/*
  *Author: Vanessa Garcia
 * Course: Comp - 003A - L01
 * Purpose: Assignment 4 Looping Statements
*/
using System;
using System.Security.Cryptography.X509Certificates;

namespace ClearConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("For-Loop Section");
            Console.WriteLine("Output a Right Triangle based on user input");
            Console.WriteLine("****************************************");

            {
                Console.Write("Enter a positive whole number: ");

                
                int limit = Convert.ToInt32(Console.ReadLine());
                //integer named limit and convert response to integer//

                string output = "#";
                //string variable named output assigned value of # //

                for (int i = 0; i <= limit; i++)
         /*looping variable named i with value of 0
         * loop as long as i is than or equal to
         * variable limit, increment i by 1
         */
                {
                    Console.WriteLine(output);
                    //output the value of the the variable output//

                    output += "#";
                    //concatenate the current value of output with #//
                }

                Console.ReadLine();


                Console.WriteLine("***************************************");
                Console.WriteLine("Foreach Friends Section");
               Console.WriteLine("Output every Friends in an Array");
                Console.WriteLine("***************************************");

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


                    Console.WriteLine("***************************************");
                    Console.WriteLine("While Loop Section");
                    Console.WriteLine("FooBar");

                    {
                        int counter2 = 1;
                        while (counter2 <= 20)

                        {
                            if (counter2 % 2 == 0 && counter2 % 5 == 0)

                            {
                                Console.WriteLine("FooBar");
                            }
                            else if (counter2 % 2 == 0)
                            {
                                Console.WriteLine("Foo");
                            }
                            else if (counter2 % 5 == 0)
                            {
                                Console.WriteLine("Bar");
                            }
                            else
                            {
                                Console.WriteLine(counter2);
                            }

                            counter2++;
                        }

                    }
                }
            }
        }
    }
}





    














