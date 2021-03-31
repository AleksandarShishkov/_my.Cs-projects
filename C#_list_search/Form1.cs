using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Integer_search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        #region Strip_menu
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Re-setting the search", "New search", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Done_button.Enabled = true;
            this.Input_box_arr.Enabled = true;
            this.Input_box_arr.Text = "";

            this.Prompt_label_2.Visible = false;

            this.Input_box_int.Text = "";
            this.Input_box_int.Visible = false;
            this.Input_box_int.Enabled = true;

            this.Output_button.Enabled = true;
            this.Output_button.Visible = false;
            this.Output_button.Text = "Show the output";

            this.Sorted_list_text.Text = " ";
            this.Sorted_list_text.Visible = false;
            this.Label.Visible = false;

            this.Output_label.Text = "";
            this.Output_label.Visible = false;


        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program locates a number`s position\n " +
                "from a user-inputted list of integers using binary search", "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have exited the program", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

        #endregion

        
        
        // list to hold the inputted integers
        List<int> list_numbers = new List<int>();
        

        private void Done_button_Click(object sender, EventArgs e)
        {
            // a string to hold the numbers separately
            string[] split_num = new string[] { };

            // re-setting the array
            split_num = null;

            split_num = Input_box_arr.Text.Split(' ');


            // calling is_integer method, assigning the value to is_int
            bool is_int = is_integer(split_num);


            // validating the inputted array
            if (split_num.Length != 10)
            {

                this.Done_button.BackColor = System.Drawing.Color.DarkRed;

                MessageBox.Show($"Invalid list size: {split_num.Length}." +
                    $"\nTry again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                this.Done_button.BackColor = System.Drawing.Color.LightBlue;
                this.Input_box_arr.Text = "";


            }else if(!is_int)
            {
                this.Done_button.BackColor = System.Drawing.Color.DarkRed;

                MessageBox.Show($"Invalid list." +
                    $"\nTry again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                this.Done_button.BackColor = System.Drawing.Color.LightBlue;
                this.Input_box_arr.Text = "";

            }
            else
            {
                this.Done_button.BackColor = System.Drawing.Color.LightGreen;
                this.Done_button.Enabled = false;
                this.Input_box_arr.Enabled = false;

                // re-setting the list_numbers
                list_numbers.Clear();

                foreach (string num_str in split_num)
                {

                    // integer to hold the validated number
                    int num_list = Int32.Parse(num_str);

                    // adding the integer to the list
                    list_numbers.Add(num_list);
                    
                }

                this.Prompt_label_2.Visible = true;
                this.Input_box_int.Visible = true;
                this.Output_button.Visible = true;

            }


        }



        private void Output_button_Click(object sender, EventArgs e)
        {

            // integer to hold searched number
            int searched_num;

            // string to hold the output for the Sorted_list_label
            string string_list_label = "";
            
            // boolean to hold true if the the parce is successfull, false if not
            bool try_parse = Int32.TryParse(Input_box_int.Text, out searched_num);



            // validating the input
            if (!try_parse)
            {
                Output_button.BackColor = System.Drawing.Color.DarkRed;
                Output_button.Enabled = false;

                MessageBox.Show($"'{Input_box_int.Text}' is not a valid input.\nTry agian", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Output_button.BackColor = System.Drawing.Color.WhiteSmoke;
                Input_box_int.Text = "";

                Output_button.Enabled = true;

            }
            else
            {
                this.Prompt_label_2.Visible = true;
                this.Label.Visible = true;
                this.Output_label.Visible = true;

                this.Output_button.Enabled = false;
                this.Input_box_int.Enabled = false;

                // calling sort_list method
                sort_list(list_numbers);

                // calling clear_strin_list method
                clear_string_list(string_list_label);


                // assigning the list to string_list_label
                for (int i = 0; i < list_numbers.Count; ++i)
                {
                    if(i != list_numbers.Count - 1)
                    {
                        string_list_label += $"{list_numbers[i]}, ";
                    }
                    else
                    {
                        string_list_label += $"{list_numbers[i]} ";
                    }
                }


              
                this.Sorted_list_text.Text = $"List: {string_list_label}";
                this.Sorted_list_text.Visible = true;

                // calling binary_search method, assigning the value to is_found
                int is_found = binary_search(list_numbers, searched_num);

                // validating if the integer is found
                if (is_found != -1)
                {
                    Output_label.Text = Convert.ToString(is_found);
                    this.Output_button.Text = "File/New_search";
                }
                else
                {
                    Label.Visible = false;

                    Output_button.BackColor = System.Drawing.Color.Red;

                    MessageBox.Show($"'{searched_num}' is not in the list.\nTry again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Output_button.BackColor = System.Drawing.Color.WhiteSmoke;
                    Output_button.Enabled = true;
                    Input_box_int.Enabled = true;

                    Input_box_int.Text = "";
                }

            }


        }



        /// <summary>
        /// method for binary searching the list with parameter for the list and for the searched num
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="search_num"></param>
        /// <returns></returns>
        private int binary_search(List<int> numbers, int search_num)
        {
            int first = 0;
            int last = numbers.Count - 1;
            int middle;
            int position = -1;

            bool found = false;

            while (first <= last && !found)
            {
                middle = (first + last) / 2;

                if (numbers[middle] == search_num)
                {
                    position = middle;
                    found = true;
                }
                else if (numbers[middle] > search_num)
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle + 1;
                }
            }

            if(position != -1)
            {
                return position + 1;
            }else
            {
                return position;
            }

        }


        /// <summary>
        /// method for list sorting
        /// </summary>
        /// <param name="numbers"></param>
        private void sort_list(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; ++i)
            {
                int min_int = numbers[i];
                int index = i;

                for (int j = i + 1; j < numbers.Count; ++j)
                {
                    if(min_int > numbers[j])
                    {
                        min_int = numbers[j];
                        index = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = min_int;
                numbers[index] = temp;
            }
        }


        /// <summary>
        /// clearing the string for the Sorted_list_text
        /// </summary>
        /// <param name="list"></param>
        private void clear_string_list(string list)
        {
            list = "";
        }



        /// <summary>
        /// method for integer validation with an argument for the inputted strings
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private bool is_integer(string[] numbers)
        {
            bool is_int;
            int num = 0;

            foreach(string num_str in numbers)
            {
                is_int = Int32.TryParse(num_str, out num);
                if(!is_int)
                {
                    return false;
                }

            }

            return true;
        }

       


      
    }
}
