using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integer_Exponent
{
    public partial class Form1 : Form
    {



        int int_num;
        int exp_num;


        public Form1()
        {
            InitializeComponent();
        }



        #region Calculations

        private void Integer_input_TextChanged(object sender, EventArgs e)
        {
            int_num = Convert.ToInt32(Integer_input.Text);
        }

        private void Exponent_input_TextChanged(object sender, EventArgs e)
        {
            exp_num = Convert.ToInt32(Exponent_input.Text);
        }

        private void Calc_button_Click(object sender, EventArgs e)
        {
            int result = calculate_exponent(int_num, exp_num);
            Result_label.Text += result;
            Calc_button.Text = "Try again";
            Calc_button.Enabled = false;
            Integer_input.Enabled = false;
            Exponent_input.Enabled = false;
        }

        private void Result_label_Click(object sender, EventArgs e)
        {
            Result_label.Text = " ";
        }


        #endregion





        /// <summary>
        /// method for calculation of the exponent
        /// </summary>
        /// <param name="int_num"></param>
        /// <param name="exponent"></param>
        /// <returns></returns>
        public int calculate_exponent(int int_num, int exponent)
        {

            int result = int_num;

            for(int i = 0;i<exponent;++i)
            {
                result *= int_num;
            }

            return result ;
        }



        #region Menu strip
        private void newTryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result_label.Text = " ";
            Integer_input.Text = "0";
            Exponent_input.Text = "0";
            Calc_button.Text = "Calculate";
            Calc_button.Enabled = true;
            Integer_input.Enabled = true;
            Exponent_input.Enabled = true;

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculates the exponent of\n an integer", "About", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nThe program will terminate", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            Application.Exit();
        }

        #endregion

    }
}
