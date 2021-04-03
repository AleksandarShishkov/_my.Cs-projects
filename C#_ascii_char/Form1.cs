using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII_chars
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
            // adding '1' to Input_int_label.Text
            this.Input_int_label.Text += "1";
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            // adding '2' to Input_int_label.Text
            this.Input_int_label.Text += "2";
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            // adding '3' to Input_int_label.Text
            this.Input_int_label.Text += "3";
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            // adding '4' to Input_int_label.Text
            this.Input_int_label.Text += "4";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            // adding '5' to Input_int_label.Text
            this.Input_int_label.Text += "5";
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            // adding '6' to Input_int_label.Text
            this.Input_int_label.Text += "6";
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            // adding '7' to Input_int_label.Text
            this.Input_int_label.Text += "7";
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            // adding '8' to Input_int_label.Text
            this.Input_int_label.Text += "8";
        }

        private void Button_9_Click_1(object sender, EventArgs e)
        {
            // addingg '9' to Input_int_label.Text
            this.Input_int_label.Text += "9";
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            // adding '0' to Input_int_label.Text
            this.Input_int_label.Text += "0";
        }

        private void Button_del_Click(object sender, EventArgs e)
        {
            // string to hold the current input
            string number_str = Input_int_label.Text;

            // validating the length of the string
            if(number_str.Length > 0)
            {
                // deleting the last character
                number_str = number_str.Remove(number_str.Length - 1, 1);
                Input_int_label.Text = number_str;
            }
            else
            {
                Input_int_label.Text = number_str;
            }


        }

        private void Show_ascii_button_Click(object sender, EventArgs e)
        {

            if (Input_int_label.Text != "")
            {

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
                this.Button_0.Enabled = false;
                this.Button_del.Enabled = false;

                this.Input_int_label.BackColor = SystemColors.ButtonFace;

                this.Show_ascii_button.Enabled = false;
                this.Show_ascii_button.Text = "- - -";


                // instance of To_ASCII class
                To_ASCII to_ascii = new To_ASCII();

                // integer to hold the converted input
                int ascii_num = Int32.Parse(Input_int_label.Text);


                if (to_ascii.set_ascii_num(ascii_num))
                {
                    Output_label.Visible = true;

                    // character to hold the converted ascii char
                    char ascii_char = to_ascii.convert_to_ascii_char(to_ascii.get_ascii_num());

                    // dispalying the output
                    Output_label.Text = Convert.ToString(ascii_char);

                }
                else
                {


                    this.Input_int_label.BackColor = Color.Red;

                    MessageBox.Show($"{ascii_num} cannot be a valid ascii number", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);


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
                    this.Button_0.Enabled = true;
                    this.Button_del.Enabled = true;

                    this.Input_int_label.Text = "";
                    this.Input_int_label.BackColor = SystemColors.ButtonHighlight;

                    this.Show_ascii_button.Enabled = true;
                    this.Show_ascii_button.Text = "Show ASCII char";
                }
            }
        }




        #endregion


        #region Menu_strip

        private void newNumToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            this.Button_0.Enabled = true;
            this.Button_del.Enabled = true;

            this.Input_int_label.Text = "";
            this.Input_int_label.BackColor = SystemColors.ButtonHighlight;

            this.Show_ascii_button.Enabled = true;
            this.Show_ascii_button.Text = "Show ASCII char";

            this.Output_label.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program converts user-defined integer into an ascii charactger", "About", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program has terminated", "Exit", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

        private void aSCIITableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

    }
}
