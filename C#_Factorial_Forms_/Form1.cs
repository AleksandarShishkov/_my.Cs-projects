using System;
using System.Windows.Forms;

namespace Factorial_Forms_
{
    public partial class Calculate_Factorial : Form
    {

        // integer to hold the integer from the text box
        int num;


        public Calculate_Factorial()
        {
            InitializeComponent();
        }


        private void Input_box_TextChanged(object sender, EventArgs e)
        {
            num = Convert.ToInt32(Input_box.Text);
        }


        private void Calculate_Button_Click(object sender, EventArgs e)
        {

            int output_calc;

            Output_label.Text = "\nFactorial of  !" + num + "  is:\n\n";
            output_calc = calc_fact(num);
            Output_label.Text += output_calc + "\n\n";
            Calculate_Button.Enabled = false;
            Calculate_Button.Text = "Try again";
           
        }

        private void Output_label_Click(object sender, EventArgs e)
        {
            Output_label.Text = " ";
        }




        public int calc_fact(int num)
        {
            if(num <= 1)
            {
                return 1;
            }
            else
            {
                return num * calc_fact(num - 1);
            }
        }





        #region Menu_Strip options
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate_Button.Text = "Calculate Factorial";
            Calculate_Button.Enabled = true;
            Output_label.Text = "---";

        }
     

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program will terminate", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nCalculating the facotial of an integer", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        #endregion

    }

}
