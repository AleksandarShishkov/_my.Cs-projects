using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors_CGame
{
    class CGame
    {

        Player_game player = new Player_game();
        PC_game pc = new PC_game();


        // static int to hold the score for the player
        static private int score_pl = 0;

        // static int to hold the score for the pc
        static private int score_pc = 0;

        // static int to hold the draws
        static private int draw = 0;

        // boolean set to false
        private bool is_choice = false;



        // defult constructor
        public CGame()
        {
            
        }

      
        // setter for the player`s score
        public void set_pl_score()
        {
            // adding 1 to score_pl
            score_pl += 1;
        }

        
        // setter for the pc`s score
        public void set_pc_score()
        {
            // adding 1 to score_pc
            score_pc += 1;
        }


        // setter for the draw score
        public void set_draw_score()
        {
            // adding 1 to draw
            draw += 1;
        }


        // getter for the pl`s score
        public int get_pl_score()
        {
            // returind score_pl
            return score_pl;
        }


        // getter for the pc`s score
        public int get_pc_score()
        {
            // returning score_pc
            return score_pc;
        }



        // getter for the draw score
        public int get_draw_score()
        {
            // returning draw
            return draw;
        }


        // printing the current score
        public void print_current_score()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Current score:");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t\t\tPlayer: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{get_pl_score()}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\tPC: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{get_pc_score()}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t\t\t\t Draw: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{get_draw_score()}");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n\n\n");
        }


        // printing the end-game score
        public void print_end_score()
        {
            Console.Write("\n\n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("End score:");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t\t\tPlayer: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{get_pl_score()}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\tPC: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{get_pc_score()}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t\t\t\t Draw: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{get_draw_score()}");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n\n\n");
        }



        // game-play
        public void CGame_play()
        {
            is_choice = false;
            print_current_score();

            while (!is_choice)
            {

                player.set_choice();


                switch (player.get_choice())
                {
                    case 0:

                        if (pc.get_pc_choice() == 0)
                        {

                            Console.Write("\nThe PC has selected ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Rock");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(". The game is draw.");
                            set_draw_score();

                        }
                        else if (pc.get_pc_choice() == 1)
                        {
                            Console.Write("\nThe PC has selected ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Paper");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(". PC wins a point.");

                            set_pc_score();

                        }
                        else if (pc.get_pc_choice() == 2)
                        {
                            Console.Write("The PC has selected ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Scissors");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(". Player wins a point.");

                            set_pl_score();
                        }

                        is_choice = true;

                        break;

                    case 1:

                        if (pc.get_pc_choice() == 0)
                        {

                            Console.Write("\nThe PC has selected ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Rock");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(". Player wins a point");
                            set_pl_score();

                        }
                        else if (pc.get_pc_choice() == 1)
                        {
                            Console.Write("\nThe PC has selected ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Paper");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(".The game is graw.");

                            set_draw_score();

                        }
                        else if (pc.get_pc_choice() == 2)
                        {
                            Console.Write("The PC has selected ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Scissors");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(". PC wins a point");

                            set_pc_score();
                        }

                        is_choice = true;

                        break;


                    case 2:

                        if (pc.get_pc_choice() == 0)
                        {

                            Console.Write("\nThe PC has selected ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Rock");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(". PC wins a point");
                            set_pc_score();

                        }
                        else if (pc.get_pc_choice() == 1)
                        {
                            Console.Write("\nThe PC has selected ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Paper");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(".Player wins a point.");

                            set_pl_score();

                        }
                        else if (pc.get_pc_choice() == 2)
                        {
                            Console.Write("The PC has selected ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Scissors");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(". The game is draw");

                            set_draw_score();

                        }

                        is_choice = true;

                        break;


                    case 3:

                        is_choice = true;
                        break;

                    default:

                        Console.Write("'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Inavlid choice");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("'. Try again");

                        is_choice = false;

                        break;
                }

            }

        }


        // getter for the user`s input for new game
        public char get_new_game()
        {

            char new_try;

            if (player.get_choice() != 3)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\nNew try (y/n)> ");

                Console.ForegroundColor = ConsoleColor.White;
                new_try = Char.Parse(Console.ReadLine());

                while (Char.ToLower(new_try) != 'y' && Char.ToLower(new_try) != 'n')
                {
                    Console.Write("\n'");

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write($"{new_try}");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("' cannot be a valid intput. Try again");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n> ");

                    Console.ForegroundColor = ConsoleColor.White;
                    new_try = Char.Parse(Console.ReadLine());


                }
            }
            else
            {
                new_try = 'n';
            }

            return new_try;
        }

    }

}

