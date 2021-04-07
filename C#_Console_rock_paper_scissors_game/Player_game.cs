using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors_CGame
{
    class Player_game
    {

        // private integer to hold the player`s choice
        private int player_choice;


        // default constructor
        public Player_game()
        {
            this.player_choice = 0;
        }


        // setter for the choice
        public void set_choice()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlayer, select (R)ock, (P)aper, (S)cissors or (Q)uit\n");
            Console.Write("> ");


            Console.ForegroundColor = ConsoleColor.White;
            char choice_char = Char.Parse(Console.ReadLine());

            // switching the input
            switch (Char.ToLower(choice_char))
            {
                case 'r':

                    player_choice = 0;
                    break;

                case 'p':

                    player_choice = 1;
                    break;

                case 's':

                    player_choice = 2;
                    break;

                case 'q':

                    player_choice = 3;
                    break;

                default:

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"'{choice_char}' cannot be a valiud choice. Try again");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n> ");
                    choice_char = Char.Parse(Console.ReadLine());

                    break;
            }

        }

        // getter for the choice
        public int get_choice()
        {
            // returning the player`s choice
            return this.player_choice;
        }

    }
}
