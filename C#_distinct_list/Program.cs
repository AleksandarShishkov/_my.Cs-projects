using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;



namespace New_app
{


    class Program
    {


        static void Main(string[] args)
        {

            // string to hold the ouptut result
            string output_string = " ";


            // a list to hold the inputted integers
            List<int> numbers = new List<int>();

            // a list to hold the distinct integers
            List<int> output_list = new List<int>();


            MessageBox.Show($"Enter {10} integers in the range \n1 - 100 included", "Enter numbers", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Console.WriteLine();


            for (int i = 0; i < 10; ++i)
            {

                // integer to temporarily hold the inputed num
                int current_num = 0;

                Console.Write("\t{0} > ", i + 1);
                current_num = Int32.Parse(Console.ReadLine());

                // validating the inputted num
                while(current_num < 1 || current_num > 100)
                {
                    Console.WriteLine($"Invalid number: {current_num}. Try again> ");
                    current_num = Int32.Parse(Console.ReadLine());
                }

                // adding the integer to the list
                numbers.Add(current_num);
            }


            output_string += "The integers are:\n\n";


            // finding the distinct elements
            output_list = numbers.Distinct().ToList();

            // calling sort_list method
            sort_list(output_list);


            foreach (int num in output_list)
            {
                // formatting the output
                output_string += $"{num} ";
            }


            

            // printing the output
            MessageBox.Show($"{output_string}\n", "Output window", MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);


        }





        /// <summary>
        /// method for sorting the list in ascending order with parameter for the list
        /// </summary>
        /// <param name="numbers"></param>
        static void sort_list(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; ++i)
            {
                int current_num = numbers[i];
                int index = i;

                for(int j = i + 1; j < numbers.Count; ++ j)
                {
                    if(current_num > numbers[j])
                    {
                        current_num = numbers[j];
                        index = j;
                    }
                }

                // temporary integer to hold the current num
                int temp_num = 0;
               
                // swapping the elements
                temp_num = current_num;
                numbers[index] = numbers[i];   
                numbers[i] = temp_num;
            }
        }



    }


}
