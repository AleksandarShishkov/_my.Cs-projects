using System;

namespace Rock_Paper_Scissors_CGame
{
    class Program
    {


       

        static void Main(string[] args)
        {
            CGame game = new CGame();

            bool end_game = false;

            
            // the game-loop
            while (!end_game)
            {

                // calling CGame_play method
                game.CGame_play();

                // validating get_new_game() method
                if (Char.ToLower(game.get_new_game()) == 'y')
                {
                    end_game = false;
                }
                else
                {
                    Console.Write("\nThe game has ended!\n\n");
                    game.print_end_score();
                    end_game = true;
                }
            }

        }
    }
}
