



        /*
         * A C# program that promts the user
         * for an integer or a string and valdates whether
         * the input is palindrom or not.
         */




using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class isPalindrome
    {

        static void Main(string[] args)
        {

            string someStr;                                                                             // a string to hold the user`s input
            bool isPalindrome = false;                                                                  // a boolean set to false
            string palindrome = "";                                                                     // a string to hold the reversed input
            bool new_try = true;                                                                        // a boolean to control the loop
            int n_try = 0;                                                                           // a character to hold the user`s input



            while (new_try)
            {

                Console.Write("\nEnter at least 3-letter word or integer> ");                               // promting the user to enter an input
                someStr = Console.ReadLine();


                while (someStr.Length < 3)                                                                  // validating the input
                {
                    Console.Write("\n'{0}' cannot be a valid input. Try again> ", someStr);

                    someStr = Console.ReadLine();
                }



                for (int i = someStr.Length - 1; i >= 0; --i)                                               // reversing the string
                {
                    palindrome += someStr[i];
                }



                if (palindrome == someStr)                                                                  // validating the reversed string
                    isPalindrome = true;
                else
                    isPalindrome = false;



                if (isPalindrome)                                                                           // validating isPalindrome
                    Console.Write("\n'{0}' is palindrome!\n", someStr);                                     // printing message indicating whether the
                else                                                                                        // input is palindrome or not
                    Console.Write("\n'{0}' is not palindrome!\n", someStr);



                Console.Write("\nAnother try? (1 - yes/0 - no)> ");                                         // prompting the user to select whether to try again
                n_try = Int32.Parse(Console.ReadLine()) ;

                while (n_try != 1 && n_try != 0)                                                            // validating the input
                {
                    Console.Write("\n'{0}' cannot be a valid input. Try again (1 - yes/0 - no)> ", n_try);
                    n_try = Int32.Parse(Console.ReadLine()) ;
                }


                if (n_try == 1)
                    new_try = true;
                else
                    new_try = false;


            }


            Console.Write("\nThe progmra has ended!\n");                                                        // printing a message indicating that the
                                                                                                                // program has ended

        }
    }
}


