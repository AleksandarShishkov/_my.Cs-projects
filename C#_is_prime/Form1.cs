using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Buttons
        private void Button_1_Click(object sender, EventArgs e)
        {
            Input_label.Text += "1";
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            Input_label.Text += "2";
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            Input_label.Text += "3";
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            Input_label.Text += "4";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            Input_label.Text += "5";
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            Input_label.Text += "6";
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            Input_label.Text += "7";
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            Input_label.Text += "8";
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            Input_label.Text += "9";
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            Input_label.Text += "0";
        }

        private void Button_del_Click(object sender, EventArgs e)
        {
            
            // temporary string to hold the inputted integer
            string number_str = Input_label.Text;

            // validating the length of the stirng
            if (number_str.Length > 0)
            {

                number_str = number_str.Remove(number_str.Length - 1, 1);
                Input_label.Text = number_str;
            }
            else
            {
                Input_label.Text = number_str;
            }

        }

        private void Is_prime_button_Click(object sender, EventArgs e)
        {


            // inscante fo the Is_Prime_class class
            Is_Prime_class prime = new Is_Prime_class();
            

            // integer to hold the user input
            int user_num;

            // boolean for integer validation
            bool try_parse;


            this.Is_prime_button.Enabled = false;
            this.Is_prime_button.Text = "- - -";

            this.Button_0.Enabled = false;
            this.Button_1.Enabled = false;
            this.Button_2.Enabled = false;
            this.Button_3.Enabled = false;
            this.Button_4.Enabled = false;
            this.Button_5.Enabled = false;
            this.Button_6.Enabled = false;
            this.Button_7.Enabled = false;
            this.Button_8.Enabled = false;
            this.Button_9.Enabled = false;
            this.Button_del.Enabled = false;


            // validating the input
            try_parse = Int32.TryParse(Input_label.Text, out user_num);


            if (!try_parse)
            {
                this.Input_label.Text = "x x x";

                MessageBox.Show("Invalid interger.", "Eror",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Is_prime_button.Enabled = true;
                this.Is_prime_button.Text = "Is_pime";

                this.Button_0.Enabled = true;
                this.Button_1.Enabled = true;
                this.Button_2.Enabled = true;
                this.Button_3.Enabled = true;
                this.Button_4.Enabled = true;
                this.Button_5.Enabled = true;
                this.Button_6.Enabled = true;
                this.Button_7.Enabled = true;
                this.Button_8.Enabled = true;
                this.Button_9.Enabled = true;
                this.Button_del.Enabled = true;

                this.Input_label.Text = "";

                this.Output_label.Visible = false;



            }
            else
            {

                this.Output_label.Visible = true;

                // setting the number
                prime.set_number(user_num);


                // validating if the number is prime
                if (prime.is_prime(prime.get_number()))
                {
                    Output_label.ForeColor = Color.Green;
                    Output_label.Text = "Is prime";
                }
                else
                {
                    Output_label.ForeColor = Color.Red;
                    Output_label.Text = "Is not prime";
                }

            }
        }

        #endregion


        #region Strip menu
        private void newNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // re-setting the buttons, clearing the string in Input_label
            this.Is_prime_button.Enabled = true;
            this.Is_prime_button.Text = "Is_pime";

            this.Button_0.Enabled = true;
            this.Button_1.Enabled = true;
            this.Button_2.Enabled = true;
            this.Button_3.Enabled = true;
            this.Button_4.Enabled = true;
            this.Button_5.Enabled = true;
            this.Button_6.Enabled = true;
            this.Button_7.Enabled = true;
            this.Button_8.Enabled = true;
            this.Button_9.Enabled = true;
            this.Button_del.Enabled = true;

            this.Input_label.Text = "" ;

            this.Output_label.Visible = false;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("A progmram that calculates if a user-defined\n" +
                "integer is a prime or not", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program has terminated", "Exit", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }


        #endregion
    }
}
