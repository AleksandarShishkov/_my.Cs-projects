

using System;
using System.Windows.Forms;


namespace ConsoleApp1
{


    class Class1 : System.Windows.Forms.Form
    {


        static void Main(string[] args)
        {


            // integer to hold the user`s choice
            int choice = 0;

            // integer to hold the number of the rows
            int num_rows;

            // int to hold the input for the new try
            int new_try = 1;


            while (new_try == 1)
            {

                // setting choice to get_choice() output
                choice = get_choice(choice);

                // switching the input
                switch (choice)
                {
                    // if choice 1 is selected
                    case 1:

                        Console.Write("\nHow many rows the triangle will have > ");
                        num_rows = Int32.Parse(Console.ReadLine());

                        while (num_rows < 1)
                        {
                            Console.Write("\n'{0}' cannot be a valid input. Try again> ", num_rows);
                            num_rows = Int32.Parse(Console.ReadLine());
                        }

                        Console.WriteLine();

                        for (int i = 0; i < num_rows; ++i)
                        {
                            for (int j = 0; j <= i; ++j)
                            {
                                Console.Write("*");
                            }

                            Console.Write("\n");
                        }

                        break;


                    // if choice 2 is selected
                    case 2:

                        Console.Write("\nHow many rows the triangle will have > ");
                        num_rows = Int32.Parse(Console.ReadLine());

                        while (num_rows < 1)
                        {
                            Console.Write("\n'{0}' cannot be a valid input. Try again> ", num_rows);
                            num_rows = Int32.Parse(Console.ReadLine());
                        }

                        Console.WriteLine();

                        for (int i = 0; i < num_rows; ++i)
                        {
                            for (int j = 0; j <= i; ++j)
                            {
                                if (j == 0 || j == i || i == num_rows - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }

                            Console.Write("\n");
                        }

                        break;


                    // if choice 3 is selected
                    case 3:

                        Console.Write("\nHow many rows the triangle will have > ");
                        num_rows = Int32.Parse(Console.ReadLine());

                        while (num_rows < 1)
                        {
                            Console.Write("\n'{0}' cannot be a valid input. Try again> ", num_rows);
                            num_rows = Int32.Parse(Console.ReadLine());
                        }

                        Console.WriteLine();

                        for (int i = num_rows - 1; i >= 0; --i)
                        {
                            for (int j = 0; j <= i; ++j)
                            {
                                Console.Write("*");
                                
                           
                            }

                            Console.Write("\n");
                        }

                        break;


                    // if choice 4 is selected
                    case 4:

                        Console.Write("\nHow many rows the triangle will have > ");
                        num_rows = Int32.Parse(Console.ReadLine());

                        while (num_rows < 1)
                        {
                            Console.Write("\n'{0}' cannot be a valid input. Try again> ", num_rows);
                            num_rows = Int32.Parse(Console.ReadLine());
                        }

                        Console.WriteLine();

                        for (int i = num_rows - 1; i >= 0; --i)
                        {
                            for (int j = 0; j <= i; ++j)
                            {
                                if (j == 0 || j == i || i == num_rows - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }

                            Console.Write("\n");
                        }

                        break;

                    // if choice 5 is selected
                    case 5:

                        Console.Write("\nHow many rows the square will have > ");
                        num_rows = Int32.Parse(Console.ReadLine());

                        while (num_rows < 1)
                        {
                            Console.Write("\n'{0}' cannot be a valid input. Try again> ", num_rows);
                            num_rows = Int32.Parse(Console.ReadLine());
                        }

                        Console.WriteLine();

                        for(int i = 0;i<num_rows;++i)
                        {
                            for(int j = 0;j< num_rows; ++j)
                            { 
                                Console.Write("* ");
                            }

                            Console.Write('\n');
                        }

                        break;

                    // if choice 6 is selected
                    case 6:


                        Console.Write("\nHow many rows the square will have > ");
                        num_rows = Int32.Parse(Console.ReadLine());

                        while (num_rows < 1)
                        {
                            Console.Write("\n'{0}' cannot be a valid input. Try again> ", num_rows);
                            num_rows = Int32.Parse(Console.ReadLine());
                        }

                        Console.WriteLine();

                        for (int i = 0; i < num_rows; ++i)
                        {
                            for (int j = 0; j < num_rows; ++j)
                            {
                                if (j == 0 || j == num_rows - 1 || i == 0 || i == num_rows - 1)
                                {
                                    Console.Write("* ");
                                }
                                else
                                {
                                    Console.Write("  ");
                                }
                            }

                            Console.Write('\n');
                        }

                        break;

                }


                // setting new_try to is_another_tru() output
                new_try = is_another_try(new_try);

            }


        }




        /// <summary>
        /// method with an argument for the choice, returns the input
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        public static int get_choice(int choice)
        {

            Console.Write("\nSelect between the following:\n\n");

            Console.Write("\t(1) up-pointed filled triangle\n");
            Console.Write("\t(2) up-pointed empty triangle\n");
            Console.Write("\t(3) down-pointed filled triangle\n");
            Console.Write("\t(4) down-pointed empty triangle\n");
            Console.Write("\t(5) filled square\n");
            Console.Write("\t(6) empty square\n");

            Console.Write("\n> ");
            choice = Int32.Parse(Console.ReadLine());

            while (choice < 1 || choice > 6)
            {
                Console.Write("\nInvalind input. Try again > ");
                choice = Int32.Parse(Console.ReadLine());
            }

            return choice;
        }





        /// <summary>
        /// method with an argument for the new_try selection, returns the input
        /// </summary>
        /// <param name="select_new_try"></param>
        /// <returns></returns>
        public static int is_another_try(int select_new_try)
        {
            Console.Write("\nNew try: \n\n\t(1) for Yes\n\t(2) for No\n> ");
            select_new_try = Int32.Parse(Console.ReadLine());

            while(select_new_try < 1 || select_new_try > 2)
            {
                Console.Write("\n'{0}' cannot be a valid selection. Try again >", select_new_try);
                select_new_try = Char.Parse(Console.ReadLine());
            }

            return select_new_try;
        }


    }


}

      

