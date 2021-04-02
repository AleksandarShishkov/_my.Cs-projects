using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace New_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // an instance of the Square class
        Square square = new Square();



        private void Show_button_Click(object sender, EventArgs e)
        {
            // integer to hold the converted heigh
            int height_input;

            // integer to hold the converted width
            int width_input;

            // validating if the input for the height is an integer
            bool try_parse_height = Int32.TryParse(Height_input_box.Text, out height_input);

            // boolean for heigh validation
            bool is_height_correct;

            // validating if the input for the width is an integer
            bool try_parse_width = Int32.TryParse(Width_input_box.Text, out width_input);

            // boolean for width validation
            bool is_width_correct;

            // validating the height
            if (try_parse_height && square.set_height(height_input))
            {
                is_height_correct = true;
                this.Height_input_box.BackColor = System.Drawing.Color.LightGreen;
                this.Height_input_box.Enabled = false;
                this.Show_button.Enabled = false;

            }
            else
            {
                is_height_correct = false;
                this.Height_input_box.BackColor = System.Drawing.Color.Red;
                this.Height_input_box.Enabled = false;
                this.Show_button.Text = ". . .";
                this.Show_button.Enabled = false;
            }


            // validating the width
            if (try_parse_width && square.set_width(width_input))
            {
                is_width_correct = true;
                this.Width_input_box.BackColor = System.Drawing.Color.LightGreen;
                this.Width_input_box.Enabled = false;
                this.Show_button.Enabled = false;
            }
            else
            {
                is_width_correct = false;
                this.Width_input_box.BackColor = System.Drawing.Color.Red;
                this.Width_input_box.Enabled = false;
                this.Show_button.Text = ". . .";
                this.Show_button.Enabled = false;
            }


            if(!is_height_correct)
            {
                MessageBox.Show($"'{height_input}' cannot be a valid height." +
                    $"Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Height_input_box.Text = "";
                this.Height_input_box.BackColor = System.Drawing.SystemColors.InactiveBorder;
                this.Height_input_box.Enabled = true;

                this.Width_input_box.Text = "";
                this.Width_input_box.BackColor = System.Drawing.SystemColors.InactiveBorder;
                this.Width_input_box.Enabled = true;

                this.Show_button.Text = "Show";
                this.Show_button.Enabled = true;


            }else if(!is_width_correct)
            {
                MessageBox.Show($"'{width_input}' cannot be a valid width." +
                    $"Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Height_input_box.Text = "";
                this.Height_input_box.BackColor = System.Drawing.SystemColors.InactiveBorder;
                this.Height_input_box.Enabled = true;

                this.Width_input_box.Text = "";
                this.Width_input_box.BackColor = System.Drawing.SystemColors.InactiveBorder;
                this.Width_input_box.Enabled = true;

                this.Show_button.Text = "Show";
                this.Show_button.Enabled = true;
            }

            
            // string to hold the outputted 
            string output_str = "\n\n\n";


            // if the input is correct printing the square
            if (is_height_correct && is_width_correct)
            {

                this.Show_button.Text = "- - -";
                string output = square.print_square(height_input, width_input, output_str);

                Output_box.SelectionAlignment = HorizontalAlignment.Center;
                Output_box.Visible = true;
                Output_box.Text = output;

            }

        }




        #region Menu_strip
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("The form is re-setting", "Re_set", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            this.Height_input_box.Text = "";
            this.Height_input_box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Height_input_box.Enabled = true;

            this.Width_input_box.Text = "";
            this.Width_input_box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Width_input_box.Enabled = true;

            this.Show_button.Text = "Show";
            this.Show_button.Enabled = true;

            Output_box.Text = "";
            Output_box.Visible = false;


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A program that draws \nuser-defined square", "About", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You`ve exited the program", "Exit", 
                MessageBoxButtons.OK, MessageBoxIcon.Stop);

            Application.Exit();
        }
        #endregion

    }
}
