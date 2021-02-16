using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // a boolean to hold the current player`s turn
        bool current_turn = true;

        // an integer to hold the number of turns
        int turn_count = 0;




        #region toolbar_region


        /// <summary>
        /// Method for the About sub-menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // a message box with information about the game
            MessageBox.Show("A game played by two players. One is with mark 'O',\n" +
                "the other with 'X'. In order to win the game, a player must\n" +
                "place three of their marks in horizontal, vertical or\n" +
                "diagonal row.", "About", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        /// <summary>
        /// Method for the New Game sub-menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // setting current_turn to true
            current_turn = true;

            // setting turn_count to '0'
            turn_count = 0;



            // enabling all the buttons, resetting the text
            this.ButtonOne.Enabled = true;
            this.ButtonOne.Text = "";

            this.ButtonTwo.Enabled = true;
            this.ButtonTwo.Text = "";

            this.ButtonThree.Enabled = true;
            this.ButtonThree.Text = "";

            this.ButtonFour.Enabled = true;
            this.ButtonFour.Text = "";

            this.ButtonFive.Enabled = true;
            this.ButtonFive.Text = "";

            this.ButtonSix.Enabled = true;
            this.ButtonSix.Text = "";

            this.ButtonSeven.Enabled = true;
            this.ButtonSeven.Text = "";

            this.ButtonEight.Enabled = true;
            this.ButtonEight.Text = "";

            this.ButtonNine.Enabled = true;
            this.ButtonNine.Text = "";


           
        }


        /// <summary>
        /// Method for the Quit sub-menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // message indicatin that the application`s been exited
            MessageBox.Show("You`re about to exit the application.", "Quit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            // exiting the application
            Application.Exit();
        }



        #endregion


        #region buttons_region



        /// <summary>
        /// Event-handler for button 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOne_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // validating the current turn and printing 'X' or 'O' in the button
            if (current_turn)
                button.Text = "X";     
            else
                button.Text = "O";


            // disablign the button
            button.Enabled = false;

            // adding 1 to turn_count
            turn_count++;

            // calling is_winner() method
            is_winner();

            // switching the turn
            current_turn = !current_turn;

        }
        

        /// <summary>
        /// Event-handler for button 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTwo_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // validating the current turn and printing 'X' or 'O' in the button
            if (current_turn)
                button.Text = "X";
            else
                button.Text = "O";


            // disablign the button
            button.Enabled = false;

            // adding 1 to turn_count
            turn_count++;

            // calling is_winner() method
            is_winner();

            // switching the turn
            current_turn = !current_turn;
        }


        /// <summary>
        /// Event-handler for button 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonThree_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // validating the current turn and printing 'X' or 'O' in the button
            if (current_turn)
                button.Text = "X";
            else
                button.Text = "O";


            // disablign the button
            button.Enabled = false;

            // adding 1 to turn_count
            turn_count++;

            // calling is_winner() method
            is_winner();

            // switching the turn
            current_turn = !current_turn;

        }


        /// <summary>
        /// Event-handler for button 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFour_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // validating the current turn and printing 'X' or 'O' in the button
            if (current_turn)
                button.Text = "X";
            else
                button.Text = "O";


            // disablign the button
            button.Enabled = false;

            // adding 1 to turn_count
            turn_count++;

            // calling is_winner() method
            is_winner();

            // switching the turn
            current_turn = !current_turn;

        }


        /// <summary>
        /// Event-handler for button 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFive_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // validating the current turn and printing 'X' or 'O' in the button
            if (current_turn)
                button.Text = "X";
            else
                button.Text = "O";


            // disablign the button
            button.Enabled = false;

            // adding 1 to turn_count
            turn_count++;

            // calling is_winner() method
            is_winner();

            // switching the turn
            current_turn = !current_turn;

        }


        /// <summary>
        /// Event-handler for button 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSix_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // validating the current turn and printing 'X' or 'O' in the button
            if (current_turn)
                button.Text = "X";
            else
                button.Text = "O";


            // disablign the button
            button.Enabled = false;

            // adding 1 to turn_count
            turn_count++;

            // calling is_winner() method
            is_winner();

            // switching the turn
            current_turn = !current_turn;

        }
        

        /// <summary>
        /// Event-handler for button 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSeven_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // validating the current turn and printing 'X' or 'O' in the button
            if (current_turn)
                button.Text = "X";
            else
                button.Text = "O";


            // disablign the button
            button.Enabled = false;

            // adding 1 to turn_count
            turn_count++;

            // calling is_winner() method
            is_winner();

            // switching the turn
            current_turn = !current_turn;
        }


        /// <summary>
        /// Event-handler for button 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEight_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // validating the current turn and printing 'X' or 'O' in the button
            if (current_turn)
                button.Text = "X";
            else
                button.Text = "O";


            // disablign the button
            button.Enabled = false;

            // adding 1 to turn_count
            turn_count++;

            // calling is_winner() method
            is_winner();

            // switching the turn
            current_turn = !current_turn;
        }


        //Event-handler for button 9
        private void ButtonNine_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // validating the current turn and printing 'X' or 'O' in the button
            if (current_turn)
                button.Text = "X";
            else
                button.Text = "O";


            // disablign the button
            button.Enabled = false;

            // adding 1 to turn_count
            turn_count++;

            // calling is_winner() method
            is_winner();

            // switching the turn
            current_turn = !current_turn;
        }



        #endregion




        #region helper_methods


        /// <summary>
        /// Method for winner validation
        /// </summary>
        private void is_winner()
        {

            bool win_game = false;


            // validating the rows
            if ((ButtonOne.Text == ButtonTwo.Text) &&
                (ButtonTwo.Text == ButtonThree.Text) &&
                (!ButtonOne.Enabled))
                win_game = true;

            else if ((ButtonFour.Text == ButtonFive.Text) &&
                (ButtonFive.Text == ButtonSix.Text) &&
                (!ButtonFour.Enabled))
                win_game = true;

            else if ((ButtonSeven.Text == ButtonEight.Text) &&
                (ButtonEight.Text == ButtonNine.Text) &&
                (!ButtonSeven.Enabled))
                win_game = true;



            // validating the columns
            else if ((ButtonOne.Text == ButtonFour.Text) &&
                (ButtonFour.Text == ButtonSeven.Text) &&
                (!ButtonOne.Enabled))
                win_game = true;

            else if ((ButtonTwo.Text == ButtonFive.Text) &&
                (ButtonFive.Text == ButtonEight.Text) &&
                (!ButtonTwo.Enabled))
                win_game = true;

            else if ((ButtonThree.Text == ButtonSix.Text) &&
                (ButtonSix.Text == ButtonNine.Text) &&
                (!ButtonThree.Enabled))
                win_game = true;



            // validating the diagonals
            else if ((ButtonOne.Text == ButtonFive.Text) &&
                (ButtonFive.Text == ButtonNine.Text) &&
                (!ButtonOne.Enabled))
                win_game = true;

            else if ((ButtonThree.Text == ButtonFive.Text) &&
                (ButtonFive.Text == ButtonSeven.Text) &&
                (!ButtonThree.Enabled))
                win_game = true;



            // validating win_game
            if (win_game)
            {


                // calling disable_buttons() method
                disable_buttons();

                // a string to hold the winner`s mark
                string winner = "";

                if (!current_turn)
                {

                    // setting winner to 'O'
                    winner = "O";

                    // adding 1 to the O`s score
                    CountO.Text = (Int32.Parse(CountO.Text) + 1).ToString();
                }
                else
                {
                    // setting winner to 'X'
                    winner = "X";

                    // adding 1 to the X`s score
                    CountX.Text = (Int32.Parse(CountX.Text) + 1).ToString();
                }



                // a text box indicating the winner
                MessageBox.Show(winner + " wins the game!", "Winner!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {

                // validating the number of turns for the draw game
                if (turn_count == 9)
                {
                    // addin 1 to the D`s score
                    CountD.Text = (Int32.Parse(CountD.Text) + 1).ToString();

                    // a text indicating the game`s draw
                    MessageBox.Show("Game`s draw!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }


        }




        /// <summary>
        /// Method to disable the buttons if game won
        /// </summary>
        private void disable_buttons()
        {

            // disabling all buttons if game won
            ButtonOne.Enabled = false;
            ButtonTwo.Enabled = false;
            ButtonThree.Enabled = false;
            ButtonFour.Enabled = false;
            ButtonFive.Enabled = false;
            ButtonSix.Enabled = false;
            ButtonSeven.Enabled = false;
            ButtonEight.Enabled = false;
            ButtonNine.Enabled = false;

        }









        #endregion

    }
}
