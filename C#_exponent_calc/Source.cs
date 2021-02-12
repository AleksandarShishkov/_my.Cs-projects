



        /*
         * A C# program that promts the user to 
         * select a type of data which will be
         * inputted (integers or doubles).
         * 
         * It then receives the data
         * and calculates the exponent of the
         * given number.
         */





using System;



namespace Cs
{
    public class Source
    {


        public static void Main(string[] args)
        {


            int option;                                                                             // an integer to hold the selected option


            char another_try = 'y';                                                                 // a char for loop control



            while (another_try == 'y')
            {

                option = Options();                                                                 // calling Options() method

                if (option == 1)                                                                    // validating the option
                {

                    int num;                                                                        // an integer to hold the number
                    int exp;                                                                        // an integer to hold the exponent
                    
                    Console.Write("\nEnter the number> ");                                          // prompting the user to enter the number
                    num = int.Parse(Console.ReadLine());

                    Console.Write("\nEnter the exponent> ");                                        // promting the user to enter the exponent
                    exp = int.Parse(Console.ReadLine());


                    Console.Write("\nThe result is: {0:d}\n", Exponent(num, exp));                  // printing the result


                }
                else if(option == 2)
                {

                    double num;                                                                     // a double to hold the number
                    double exp;                                                                     // a double to hold the exponent

                    Console.Write("\nEnter the number> ");                                          // promting the user to enter the number
                    num = double.Parse(Console.ReadLine());         

                    Console.Write("\nEnter the exponent> ");                                        // promp[ting the user to enter the exponent
                    exp = double.Parse(Console.ReadLine());

                    Console.Write("\nThe result is: {0:F2}\n", Exponent(num, exp));                 // printing the result

                }
                else
                {
                    Console.Write("\nInvalid option!\n");                                           // printing message if incorrect option is selected
                }



                Console.Write("\nDo you want to try again (y/n)> ");                                // promting the user to select whether another try will be made
                another_try = char.Parse(Console.ReadLine());

                while (another_try != 'y' && another_try != 'n')                                    // validating the input
                {
                    Console.Write("\n'{0}' cannot be a valid input. Try again> ", another_try);
                    another_try = char.Parse(Console.ReadLine()); 
                }
            }

            Console.Write("\nThe program has ended!\n");                                            // a message indicating the ned of the program

        }

                

        public static int Options()                                                                 // Options() method definition
        {

            int option;                                                                             // an integer to hold the option selected

            Console.Write("\n\tSelect between the following:\n\n");                                 // printing the options
            Console.Write("\n\t(1) for integers");
            Console.Write("\n\t(2) for doubles");
            Console.Write("\n\t> ");

            option = int.Parse(Console.ReadLine());                                                 // prompting the user for an input

            return option;                                                                          // returning the option
        }




        public static long Exponent(int num, int exp)                                               // an overloaded Exponent() method definition with arguments for
        {                                                                                           // the integer and the exponent


            int res = 1;                                                                            // an integer to hold the result

            for (int i = 0; i < exp; ++i)                                                           // calculating the result
            {
                res *= num;
            }

            return res;                                                                             // returning the result
        }



        public static double Exponent(double num, double exp)                                       // an overloaded Exponent() method definition with arguments for
        {                                                                                           // the double and the double exponent


            double res = 1;                                                                         // a double to hold the result

            for (int i = 0; i < exp; ++i)                                                           // calculating the result
            {
                res *= num;
            }

            return res;                                                                             // returning the result
        }

    }
}