using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors_CGame
{
    public class PC_game
    {


        // private property for the pc`s choice
        private int pc_game;



        // defualt constructor
        public PC_game()
        {
            this.pc_game = 0;
        }



        public int get_pc_choice()
        {
            Random rand_num = new Random();

            // randomising the pc`s choice
            pc_game = rand_num.Next(3);

            // returning the result
            return this.pc_game;

        }



    }
}
