


        /*
         * A C# program that promts the user
         * to input the two sides of a triangle 
         * and it`s hypotenuse.
         * 
         * It calculates whether the triangle holds
         * Pythagorean triples and displays the result.
         * 
         * The user can exit the program by selecting '0'
         * for side 'a'.
         */



using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Cs
{
    class Source
    {
        static void Main(string[] args)
        {

            int side1 = 1;                                                              // an integer to hold side1
            int side2;                                                                  // an integer to hold side2
            int hypotenuse;                                                             // an integer to hold the hypotenuse

            int a;                                                                      // an integert to hold sqrt(side1)
            int b;                                                                      // an integer to hold sqrt(side2)
            int c;                                                                      // an integer to hold sqrt(hypotenuse)


            while (side1 != 0)                                                          // a user controlled loop
            {

                Console.Write("\nEnter side 'a' of the triangle or '0' to quit> ");     // promting the user to enter side 'a'
                side1 = Int32.Parse(Console.ReadLine());

                if (side1 == 0)                                                         // validating the input
                    break;


                Console.Write("\nEnter side 'b' of the triangle> ");                    // promting the user to enter side 'b'
                side2 = Int32.Parse(Console.ReadLine());


                Console.Write("\nEnter the hypotenuse of the triangle> ");              // promting the user to enter the hypotenuse
                hypotenuse = Int32.Parse(Console.ReadLine());




                a = side1 * side1;                                                      // assigning sqrt(side1) to a
                b = side2 * side2;                                                      // assigning sqrt(side2) to b
                c = hypotenuse * hypotenuse;                                            // assigning sqwrt(ypotenuse) to c


                if (a + b == c)                                                         // validating the result
                {                                                                       // printing the input

                    Console.Write("\nThis is a pythagorean triple.\nsqr(a) + sqr(b) == " +
                        "sqr(c)\n");
                    Console.Write("\n'{0}' + '{1}' = '{2}'\n", a, b, c);
                }
                else
                {                                                                       // printing the input
                    Console.Write("\nThis is not a pythagorean triple.\nsqr(a) + sqr(b) != " +
                        "sqr(c)\n");
                    Console.Write("\n'{0}' + '{1}' = '{2}', not '{3}'\n", a, b, a + b, c);
                }


            }


            Console.Write("\nThe program has ended!\n");                                // a message indicating that the
                                                                                        // program has ended

        }
    }
}



