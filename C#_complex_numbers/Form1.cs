using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complex_numbers
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        Numbers complex_num = new Numbers();


        #region Calculate

        private void Calc_button_Click(object sender, EventArgs e)
        {

            // booleans for input validation
            bool is_num1_real_valid;
            bool is_num1_img_valid;
            bool is_num2_real_valid;
            bool is_num2_img_valid;
            bool is_math_operator_valid;



            // calling validate_num_1_real method
            if (complex_num.validate_num1_real(Number_1_real_box.Text))
            {
                Number_1_real_box.Enabled = false;
                Number_1_real_box.BackColor = System.Drawing.Color.LightGreen;

                is_num1_real_valid = true;
            }
            else
            {

                Number_1_real_box.BackColor = System.Drawing.Color.Red;
                Number_1_real_box.Enabled = false;

                Calc_button.Text = "- - -";
                Calc_button.Enabled = false;
                is_num1_real_valid = false;
            }

               


            // calling validate_num1_img method
            if (complex_num.validate_num1_img(Number_1_img_box.Text))
            {
                Number_1_img_box.Enabled = false;
                Number_1_img_box.BackColor = System.Drawing.Color.LightGreen;

                is_num1_img_valid = true;
            }
            else
            {

                Number_1_img_box.BackColor = System.Drawing.Color.Red;
                Number_1_img_box.Enabled = false;

                Calc_button.Text = "- - -";
                Calc_button.Enabled = false;
                is_num1_img_valid = false;

            }



            // calling validate_num2_real method
            if (complex_num.validate_num2_real(Number_2_real_box.Text))
            {
                Number_2_real_box.Enabled = false;
                Number_2_real_box.BackColor = System.Drawing.Color.LightGreen;

                is_num2_real_valid = true;
            }
            else
            {

                Number_2_real_box.BackColor = System.Drawing.Color.Red;
                Number_2_real_box.Enabled = false;

                Calc_button.Text = "- - -";
                Calc_button.Enabled = false;
                is_num2_real_valid = false;            
                
            }



            // calling validate_num2_img method
            if (complex_num.validate_num2_img(Number_2_img_box.Text))
            {
                Number_2_img_box.Enabled = false;
                Number_2_img_box.BackColor = System.Drawing.Color.LightGreen;

                is_num2_img_valid = true; ;
            }
            else
            {

                Number_2_img_box.BackColor = System.Drawing.Color.Red;
                Number_2_img_box.Enabled = false;

                Calc_button.Text = "- - -";
                Calc_button.Enabled = false;
                is_num2_img_valid = false;
            }



            if (complex_num.validate_math_opeator(Arithmetic_box.Text))
            {
                Arithmetic_box.Enabled = false;
                Arithmetic_box.BackColor = System.Drawing.Color.LightGreen;

                is_math_operator_valid = true;

            }
            else
            {
                Arithmetic_box.BackColor = System.Drawing.Color.Red;
                Arithmetic_box.Enabled = false;

                Calc_button.Text = "- - -";
                Calc_button.Enabled = false;
                is_math_operator_valid = false;
            }


            if (!is_num1_real_valid)
            {

                MessageBox.Show($"'{Number_1_real_box.Text}' cannot be a valid number.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);


                Number_1_real_box.Text = "";
                Number_1_real_box.Enabled = true;
                Number_1_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_1_img_box.Text = "";
                Number_1_img_box.Enabled = true;
                Number_1_img_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_real_box.Text = "";
                Number_2_real_box.Enabled = true;
                Number_2_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_img_box.Text = "";
                Number_2_img_box.Enabled = true;
                Number_2_img_box.BackColor = System.Drawing.SystemColors.Window;

                Arithmetic_box.Text = "";
                Arithmetic_box.Enabled = true;
                Arithmetic_box.BackColor = System.Drawing.SystemColors.Window;

                Calc_button.Text = "Calculate";
                Calc_button.Enabled = true;

            }
            else if (!is_num1_img_valid)
            {
                MessageBox.Show($"'{Number_1_img_box.Text}' cannot be a valid number.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);


                Number_1_real_box.Text = "";
                Number_1_real_box.Enabled = true;
                Number_1_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_1_img_box.Text = "";
                Number_1_img_box.Enabled = true;
                Number_1_img_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_real_box.Text = "";
                Number_2_real_box.Enabled = true;
                Number_2_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_img_box.Text = "";
                Number_2_img_box.Enabled = true;
                Number_2_img_box.BackColor = System.Drawing.SystemColors.Window;

                Arithmetic_box.Text = "";
                Arithmetic_box.Enabled = true;
                Arithmetic_box.BackColor = System.Drawing.SystemColors.Window;

                Calc_button.Text = "Calculate";
                Calc_button.Enabled = true;

            }
            else if (!is_num2_real_valid)
            {
                MessageBox.Show($"'{Number_2_real_box.Text}' cannot be a valid number.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);


                Number_1_real_box.Text = "";
                Number_1_real_box.Enabled = true;
                Number_1_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_1_img_box.Text = "";
                Number_1_img_box.Enabled = true;
                Number_1_img_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_real_box.Text = "";
                Number_2_real_box.Enabled = true;
                Number_2_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_img_box.Text = "";
                Number_2_img_box.Enabled = true;
                Number_2_img_box.BackColor = System.Drawing.SystemColors.Window;

                Arithmetic_box.Text = "";
                Arithmetic_box.Enabled = true;
                Arithmetic_box.BackColor = System.Drawing.SystemColors.Window;

                Calc_button.Text = "Calculate";
                Calc_button.Enabled = true;

            }
            else if (!is_num2_img_valid)
            {
                MessageBox.Show($"'{Number_2_img_box.Text}' cannot be a valid number.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);



                Number_1_real_box.Text = "";
                Number_1_real_box.Enabled = true;
                Number_1_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_1_img_box.Text = "";
                Number_1_img_box.Enabled = true;
                Number_1_img_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_real_box.Text = "";
                Number_2_real_box.Enabled = true;
                Number_2_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_img_box.Text = "";
                Number_2_img_box.Enabled = true;
                Number_2_img_box.BackColor = System.Drawing.SystemColors.Window;

                Arithmetic_box.Text = "";
                Arithmetic_box.Enabled = true;
                Arithmetic_box.BackColor = System.Drawing.SystemColors.Window;

                Calc_button.Text = "Calculate";
                Calc_button.Enabled = true;

            }
            else if (!is_math_operator_valid)
            {
                MessageBox.Show($"'{Arithmetic_box.Text}' cannot be a valid operator.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);


                Number_1_real_box.Text = "";
                Number_1_real_box.Enabled = true;
                Number_1_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_1_img_box.Text = "";
                Number_1_img_box.Enabled = true;
                Number_1_img_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_real_box.Text = "";
                Number_2_real_box.Enabled = true;
                Number_2_real_box.BackColor = System.Drawing.SystemColors.Window;

                Number_2_img_box.Text = "";
                Number_2_img_box.Enabled = true;
                Number_2_img_box.BackColor = System.Drawing.SystemColors.Window;

                Arithmetic_box.Text = "";
                Arithmetic_box.Enabled = true;
                Arithmetic_box.BackColor = System.Drawing.SystemColors.Window;

                Calc_button.Text = "Calculate";
                Calc_button.Enabled = true;

            }
            else                
            {
                Calc_button.Text = "Result";
                Calc_button.Enabled = false;

                Result_real_box.Visible = true;

                Result_img_box.Visible = true;
                Result_complex_label.Visible = true;



                // a string to hold the output for the real number
                string output_real_num = Convert.ToString(complex_num.calc_real_num(complex_num.get_num1_real(),
                    complex_num.get_num2_real(), complex_num.get_math_operator()));


                string output_img_num = Convert.ToString(complex_num.calc_img_num(complex_num.get_num1_img(),
                    complex_num.get_num2_img(), complex_num.get_math_operator()));


                Result_real_box.Text = output_real_num;
                Result_real_box.Enabled = false;

                Result_img_box.Text = output_img_num;
                Result_img_box.Enabled = false;


            }

            #endregion


        }





        #region Menu_strip
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Number_1_real_box.Enabled = false;
            Number_1_img_box.Enabled = false;
            Number_2_real_box.Enabled = false;
            Number_2_img_box.Enabled = false;
            Arithmetic_box.Enabled = false;
            Calc_button.Enabled = false;
            Result_real_box.Enabled = false;
            Result_img_box.Enabled = false;

            MessageBox.Show("Program re-setting", "Re-set", MessageBoxButtons.OK, MessageBoxIcon.Information);



            Number_1_real_box.Enabled = true;
            Number_1_real_box.Text = "";
            Number_1_real_box.BackColor = System.Drawing.SystemColors.Window;

            Number_1_img_box.Enabled = true;
            Number_1_img_box.Text = "";
            Number_1_img_box.BackColor = System.Drawing.SystemColors.Window;


            Number_2_real_box.Enabled = true;
            Number_2_real_box.Text = "";
            Number_2_real_box.BackColor = System.Drawing.SystemColors.Window;

            Number_2_img_box.Enabled = true;
            Number_2_img_box.Text = "";
            Number_2_img_box.BackColor = System.Drawing.SystemColors.Window;

            Arithmetic_box.Enabled = true;
            Arithmetic_box.Text = "";
            Arithmetic_box.BackColor = System.Drawing.SystemColors.Window;

            Calc_button.Enabled = true;
            Calc_button.Text = "Calculate";

            Result_real_box.Enabled = true;
            Result_real_box.Text = "";
            Result_real_box.Visible = false;


            Result_img_box.Enabled = true;
            Result_img_box.Text = "";
            Result_img_box.Visible = false;

            Result_complex_label.Visible = false;


        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Number_1_real_box.Enabled = false;
            Number_1_img_box.Enabled = false;
            Number_2_real_box.Enabled = false;
            Number_2_img_box.Enabled = false;
            Arithmetic_box.Enabled = false;
            Calc_button.Enabled = false;
            Result_real_box.Enabled = false;
            Result_img_box.Enabled = false;

            MessageBox.Show("Program that calculates arithmetic operations\nwith complex numbers", 
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Number_1_real_box.Enabled = true;
            Number_1_img_box.Enabled = true;
            Number_2_real_box.Enabled = true;
            Number_2_img_box.Enabled = true;
            Arithmetic_box.Enabled = true;
            Calc_button.Enabled = true;
            Result_real_box.Enabled = true;
            Result_img_box.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program has terminated", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }

        #endregion
    }
}
