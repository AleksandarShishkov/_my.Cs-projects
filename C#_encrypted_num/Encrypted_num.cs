


        /*
         * A C# program that prompts the
         * user to enter a four-digit integer.
         * 
         * It then validates it and
         * transforms it into encrypted code. 
         * 
         */





using System;

namespace Cs
{
    class Encrypted_num
    {
        static void Main(string[] args)
        {
            int integer_input;                                                      // an integer to hold the users input
            int integer_valid;                                                      // an integer to hold the input after validation
            int digit1 = 0;                                                         // an integer to hold the first digit
            int digit2 = 0;                                                         // an integer to hold the second digit
            int digit3 = 0;                                                         // an integer to hold the third digit
            int digit4 = 0;                                                         // an integer to hold the fourth digit

            int countNum = 0;                                                       // an integer to keep count of the digits
            int temp;                                                               // an integer to hold the temporary digit
            bool validInteger = false;                                              // a boolean for the validation loop



            Console.Write("\nEnter four digit integer> ");                          // prompting the user to enter an integer
            integer_input = Int32.Parse(Console.ReadLine());

            integer_valid = integer_input;                                          // assigning the value to integer_valid

            while (!validInteger)                                                   // validating the input
            {

                while (integer_input > 0)
                {
                    integer_input /= 10;
                    countNum++;
                }

                if (countNum < 4 || countNum > 4)
                {
                    Console.Write("\nInvalid integer. Try again> ");                // promting the user to re-enter if invalid
                    integer_input = Int32.Parse(Console.ReadLine());
                    validInteger = false;
                }
                else
                    validInteger = true;

            }

            integer_input = integer_valid;                                          // assigning the validated value to integer_input


            digit1 = integer_valid / 1000;                                          // assigning the first digit to digit1
            integer_valid %= 1000;

            digit2 = integer_valid / 100;                                           // assigning the second digit to digit2
            integer_valid %= 100;

            digit3 = integer_valid / 10;                                            // assigning the third digit to digit3
            integer_valid %= 10;

            digit4 = integer_valid;                                                 // assigning the fourth digit to digit4


            digit1 = (digit1 + 7) % 10;                                             // manipulating the values
            digit2 = (digit2 + 7) % 10;
            digit3 = (digit3 + 7) % 10;
            digit4 = (digit4 + 7) % 10;
            
                      

            temp = digit3;                                                          // swapping digit1 with digit3
            digit3 = digit1;
            digit1 = temp;

            temp = digit2;                                                          // swapping digit2 with digit4
            digit2 = digit4;
            digit4 = temp;

            

            Console.Write("\nPress <Enter> to continue. . .");                      // priomting the user to press <Enter>
            Console.ReadLine();



            Console.Write("\n\nOriginal number:  {0}", integer_input);              // printing the original number
            Console.Write("\nEncrypted number: {0}{1}{2}{3}\n",                     // printing the encrypted number
                digit1, digit2, digit3, digit4);


            Console.Write("\nThe program has ended!\n");                            // a message indicating that the program has ended

        }
    }
}




