


        /*
         * A C# program that prompts the user
         * for an integer input and calculates
         * the factorial of the given number.
         */





using System;
using System.Collections.Generic;
using System.Text;

namespace Cs
{
    class factorial
    {

        static void Main(string[] args)
        {

            int integer_input;                                                                  // an integer to hold the user`s input
            int factorial = 0;                                                                  // an integer to hold the factorial
            bool another_try = true;                                                            // a boolean to control the loop
            char yes_n0;                                                                        // a char to hold the user`s input



            while(another_try)                                                                  // outer loop
            {
                Console.Write("\nEnter an integer> ");                                          // promting the user to enter an integer
                integer_input = Int32.Parse(Console.ReadLine());


                while(integer_input < 1)                                                        // validating the input
                {
                    Console.Write("\n'{0}' cannot be a valid integer. Try again> ");
                    integer_input = Int32.Parse(Console.ReadLine());
                }


                if(integer_input == 1)                                                          
                {
                    Console.Write("\n!{0} = {1}", integer_input, 1);                            // printing the result
                }
                else
                {
                    for (int i = 1; i < integer_input + 1; i++)                                 // calculating the factorial
                    {
                        factorial = integer_input * i;
                    }

                    Console.Write("\n!{0}  =  {1}", integer_input, factorial);                  // printing the result
                }




                Console.Write("\n\nAnother try? (y/n)> ");                                      // promting the user to select
                yes_n0 = char.Parse(Console.ReadLine());                                        // another input


                while (char.ToLower(yes_n0) != 'y' && char.ToLower(yes_n0) != 'n')              // validating the choice
                {
                    Console.Write("\n'{0}' cannot be a valid input. Try again> ", yes_n0) ;
                    yes_n0 = char.Parse(Console.ReadLine());
                }


                if (char.ToLower(yes_n0) == 'y')
                {
                    another_try = true;                                                         // setting another_try to true if 'y'
                }
                else
                    another_try = false;                                                        // setting another_try to false if 'n'
            }


            Console.Write("\nThe program has ended!\n");                                        // a message indicating the end of the program
        }
    }
}


