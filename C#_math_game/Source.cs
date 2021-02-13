



        /*
         * A C# program that promts the user
         * to select an arithmeric operation 
         * troughout a list of options. 
         * 
         * It then asks the user to calculate the result.
         * If correct, the user gains a point. 
         * The game ends whenver the user reaches 100 points
         * or selects '0' as a option. 
         */






using System;


namespace Cs
{
    class NewClass 
    {


        public static void Main(string[] args)
        {


            bool another_try = true;                                                                                    // a boolean for game-loop control
            int points = 0;                                                                                             // an integer to hold the current points
            int choice;                                                                                                 // an integer to hold the choice


            while (another_try)
            {

                choice = show_options();                                                                                // calling show_options() method, assigning the value to
                                                                                                                        // choice


                switch (choice)                                                                                         // switching the choice
                {
                    case 1:                                                                                             // validating the input
                        
                        if(addition())                                                                                  // calling addition() method
                        {
                            ++points;                                                                                   // adding 1 to points if correct answer

                            if(points == 100)                                                                           // validating the points
                            {
                                Console.Write("\n\nCongrats! You`ve reched 100 points!\n");
                                another_try = false;                                                                    // exiting the game-loop
                            }
                        }
                                                
                        break;

                    case 2:

                        if (substraction())                                                                             // calling substraction() method
                        {
                            ++points;                                                                                   // adding 1 to points if correct answer

                            if (points == 100)                                                                          // validating the points
                            {
                                Console.Write("\n\nCongrats! You`ve reched 100 points!\n");
                                another_try = false;                                                                    // exiting the game-loop
                            }
                        }

                        break;

                    case 3:

                        if (multiplication())                                                                           // calling multiplication() method
                        {
                            ++points;                                                                                   // adding 1 to pooints if correct answer

                            if (points == 100)                                                                          // validating the points
                            {
                                Console.Write("\n\nCongrats! You`ve reched 100 points!\n");
                                another_try = false;                                                                    // exiting the game-loop
                            }
                        }

                        break;

                    case 4:

                        if (division())                                                                                 // calling division() method
                        {   
                            ++points;                                                                                   // adding 1 to points if correct answer

                            if (points == 100)                                                                          // validating the points
                            {
                                Console.Write("\n\nCongrats! You`ve reched 100 points!\n");
                                another_try = false;                                                                    // exitin the game-loop
                            }
                        }

                        break;


                    case 5:

                        Console.Write("\nCurrent points: {0}\n", points);                                               // printin the current points
                        Console.Write("{0} more to go!\n", 100 - points);                                               // a counter indicating how much points are needed

                        break;


                    case 0:

                        Console.Write("\nYou have exited the program! " +                                               // a message indicating the end of the program
                            "\nBetter Luck next time!\n");
                        another_try = false;

                        break;


                    default:

                        Console.Write("\nInvalid input!\n");                                                            // a message indicating that incorrect oprion was selected
                        break;
                }

            }

        }


        public static int show_options()                                                                                // show_options() method definition
        {

            int choice;                                                                                                 // an integer to hold the choice

            Console.Write("\n\n\tSelect between the follwoing arithmetic operations and\n" +                            // printing the options
                "\ttry to reach 100 points:\n");
            Console.WriteLine("\n\t(1) for addition");
            Console.WriteLine("\t(2) for substraction");
            Console.WriteLine("\t(3) for multiplication");
            Console.WriteLine("\t(4) for division");
            Console.WriteLine("\t(5) to view the current points");
            Console.WriteLine("\t(0) to quit the program");

            Console.Write("\t> ");                                                                                      // prompting the user to enter the choice
            choice = Int32.Parse(Console.ReadLine());


            return choice;                                                                                              // returning the input

        }



        public static bool addition()                                                                                   // addition() method definition 
        {
            Random a = new Random();                                                                                    // creating an instance of type Random
            
            int res;                                                                                                    // an integer to hold the result

            int num1 = a.Next(1, 100);                                                                                  // randomising num1
            int num2 = a.Next(1, 100);                                                                                  // randomising num2


            Console.Write("\nYou have selected 'addition'.\n\nWhat is the " +                                           // printing the numbers
                "result of the following:\n");

            Console.Write("\n\t'{0}'\n", num1);
            Console.Write("\t +  \n");
            Console.Write("\t'{0}'\n", num2);
            Console.Write("\t-----\n");

            Console.Write("\nEnter your input here> ");                                                                 // prompting the user to enter the result
            res = Int32.Parse(Console.ReadLine());
                       
            
            if(res == (num1 + num2))                                                                                    // validating the result
            {
                Console.Write("\n'{0}' is the correct answer! You have earned a point!\n", res);                        // printing message indicating that the given answer is correct
                Console.Write("\nPress <Enter> to continue. . .");                                                      // promting the user to press <Enter> to continue
                Console.ReadKey();

                return true;                                                                                            // returning true

            }
            else
            {
                Console.Write("\n'{0}' isn`t correct. The answer is: '{1}'\n", res, num1 + num2);                       // printing message indicating that the given anwer isn`t correct
                Console.Write("No point earned!\n");

                Console.Write("\nPress <Enter> to continue. . .");                                                      // promting the user to press <Enter> to continue
                Console.ReadKey();

                return false;                                                                                           // returnin false

            }

          

        }



        public static bool substraction()                                                                               // ubstraction() method definition
        {

            Random a = new Random();                                                                                    // creating an instance of type Random

            int res;                                                                                                    // an integer to hold the result

            int num1 = a.Next(50, 100);                                                                                 // randomising num1
            int num2 = a.Next(1, 50);                                                                                   // randomising num2



            Console.Write("\nYou have selected 'substraction'.\n\nWhat is the " +                                       // prnting the numbers
                "result of the following:\n");

            Console.Write("\n\t'{0}'\n", num1);
            Console.Write("\t -  \n");
            Console.Write("\t'{0}'\n", num2);
            Console.Write("\t-----\n");

            Console.Write("\nEnter your input here> ");                                                                 // promting the user to enter the result
            res = Int32.Parse(Console.ReadLine());


            if (res == (num1 - num2))                                                                                   // validating the result
            {
                Console.Write("\n'{0}' is the correct answer! You have earned a point!\n", res);                        // printing message that the given answer is correct
                Console.Write("\nPress <Enter> to continue. . .");                                                      // promting the user to press <Enter> to continue
                Console.ReadKey();

                return true;                                                                                            // returning true

            }
            else
            {
                Console.Write("\n'{0}' isn`t correct. The answer is: '{1}'\n", res, num1 - num2);                       // printing message indicating that the given answer ins`t correct
                Console.Write("No point earned!\n");                                                                    

                Console.Write("\nPress <Enter> to continue. . .");                                                      // promting the user to press <Enter> to continue
                Console.ReadKey();

                return false;                                                                                           // returning false

            }
        }



        public static bool multiplication()                                                                             // multiplication() method definition
        {

            Random a = new Random();                                                                                    // creating an instance of type Random

            int res;                                                                                                    // an integer to hold the result

            int num1 = a.Next(1, 20);                                                                                   // randomising num1
            int num2 = a.Next(1, 20);                                                                                   // randomising num2


            Console.Write("\nYou have selected 'multiplication'.\n\nWhat is the "  +                                    // prnitning the numbers
                "result of the following:\n");

            Console.Write("\n\t'{0}'\n", num1);
            Console.Write("\t *  \n");
            Console.Write("\t'{0}'\n", num2);
            Console.Write("\t-----\n");

            Console.Write("\nEnter your input here> ");                                                                 // prompting the user to enter the result
            res = Int32.Parse(Console.ReadLine());


            if (res == (num1 * num2))                                                                                   // validating the result
            {
                Console.Write("\n'{0}' is the correct answer! You have earned a point!\n", res);                        // printing message indicating that the given answer ins`t correct
                Console.Write("\nPress <Enter> to continue. . .");                                                      // promting the user to press <Enter> to continue
                Console.ReadKey();

                return true;                                                                                            // returning true

            }
            else
            {
                Console.Write("\n'{0}' isn`t correct. The answer is: '{1}'\n", res, num1 * num2);                       // printing message indicating that the given answer isn`t correct
                Console.Write("No point earned!\n");                

                Console.Write("\nPress <Enter> to continue. . .");                                                      // promting the user to press <Enter> to continue
                Console.ReadKey();

                return false;                                                                                           // returning false

            }
        }



        public static bool division()                                                                                   // division() method definition
        {

            Random a = new Random();                                                                                    // creating an instance of type Random    

            double res;                                                                                                 // a double to hold the result

            double num1 = a.Next(20, 100);                                                                              // randomising num1
            double num2 = a.Next(1, 20);                                                                                // randomising num2
            

            Console.Write("\nYou have selected 'division'.\n\nWhat is the " +                                           // printing the numbers
                "result of the following (enter result within 2 decimal places):\n");

            Console.Write("\n\t'{0}'\n", num1);
            Console.Write("\t /  \n");
            Console.Write("\t'{0}'\n", num2);
            Console.Write("\t-----\n");

            Console.Write("\nEnter your input here> ");                                                                 // promting the user to enter the result
            res = Double.Parse(Console.ReadLine());


            if (res == (num1 / num2))                                                                                   // validating the result
            {
                Console.Write("\n'{0:F2}' is the correct answer! You have earned a point!\n", res);                     // printing message indicating that the given answer is correct
                Console.Write("\nPress <Enter> to continue. . .");                                                      // promting the user to press <Enter> to continue
                Console.ReadKey();

                return true;                                                                                            // returning true

            }
            else
            {
                Console.Write("\n'{0}' isn`t correct. The answer is: '{1:F2}'\n", res, num1 / num2);                    // printing message indicating that the given answe isn`t correct
                Console.Write("No point earned!\n");                            

                Console.Write("\nPress <Enter> to continue. . .");                                                      // promting the user to press <Enter> to continue
                Console.ReadKey();

                return false;                                                                                           // returning false

            }
        }

    }
}




