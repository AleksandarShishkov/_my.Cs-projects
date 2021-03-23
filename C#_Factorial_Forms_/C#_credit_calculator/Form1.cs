using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // integer to hold the id
        int account_num;

        // double to hold the allowed credit limit
        double allowed_limit;

        // double to hold the monthly ballance
        double monthly_ballance;

        // amount to hold the amount of the credits
        double amount_credit;

        // double to hold the amount of the charges
        double amount_charges;



        #region text_Boxes and calculation

        private void Allowed_limit_text_box_TextChanged(object sender, EventArgs e)
        {
            this.allowed_limit = Convert.ToDouble(Allowed_limit_text_box.Text);
        }

        private void Acc_text_box_TextChanged(object sender, EventArgs e)
        {
            this.account_num = Convert.ToInt32(Acc_text_box.Text);
        }

        private void Ballance_text_box_TextChanged(object sender, EventArgs e)
        {
            this.monthly_ballance = Convert.ToDouble(Ballance_text_box.Text);
        }

        private void Charges_text_box_TextChanged(object sender, EventArgs e)
        {
            this.amount_charges = Convert.ToDouble(Charges_text_box.Text);
        }

        private void Credits_text_box_TextChanged(object sender, EventArgs e)
        {
            this.amount_credit = Convert.ToDouble(Credits_text_box.Text);
        }
        private void Calc_button_Click(object sender, EventArgs e)
        {
            double total = (monthly_ballance + amount_charges) - amount_credit;


            Output_label.Text = "Account num: " + account_num + "\n\n";
            
            if(total > allowed_limit)
            {
                double limit = allowed_limit - total;

                Output_label.ForeColor = System.Drawing.Color.Red;
                Output_label.Text += "Credit limit exceeded.\n\n";
                Output_label.Text += "Current amount $" + limit + '\n';
            }
            else
            {
                double limit = allowed_limit - total;
                Output_label.ForeColor = System.Drawing.Color.Green;
                Output_label.Text += "Credit limit not exceeded.\n\n";
                Output_label.Text += "Current amount $" + limit + '\n';
            }




            Allowed_limit_text_box.Enabled = false;
            Acc_text_box.Enabled = false;
            Ballance_text_box.Enabled = false;
            Charges_text_box.Enabled = false;
            Credits_text_box.Enabled = false;
            Calc_button.Text = "Try again> ";
            Calc_button.BackColor = System.Drawing.Color.LightGray;
            Calc_button.Enabled = false;



        }

        private void Output_label_Click(object sender, EventArgs e)
        {
            Output_label.Text = " ";
        }


        #endregion




        #region menu strip


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Allowed_limit_text_box.Text = "0";
            Allowed_limit_text_box.Enabled = true;

            this.Acc_text_box.Text = "0";
            Acc_text_box.Enabled = true;

            this.Ballance_text_box.Text = "0";
            Ballance_text_box.Enabled = true;

            this.Charges_text_box.Text = "0";
            Charges_text_box.Enabled = true;

            this.Credits_text_box.Text = "0";
            Credits_text_box.Enabled = true;

            this.Output_label.Text = " ";


            Calc_button.Text = "Calculate";
            Calc_button.BackColor = System.Drawing.Color.SkyBlue;
            Calc_button.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calcualates the monthly credit limit", "About", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program has terminated", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            Application.Exit();
             
        }

        #endregion
    }
}
