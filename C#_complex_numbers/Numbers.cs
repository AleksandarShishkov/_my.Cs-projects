using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_numbers
{
    internal class Numbers
    {

        // private members for the complex numbers - real and imaginary part
        private float num1_real;
        private float num1_img;
        private float num2_real;
        private float num2_img;

        // boolean for input validation
        private bool try_parse;

        // private char to hold the math operator
        private string math_operator;

        
        // default constructor, setting the variables to 0.0
        public Numbers()
        {
            this.num1_real = 0.0f;
            this.num1_img = 0.0f;
            this.num2_real = 0.0f;
            this.num2_img = 0.0f;
            this.math_operator = "0";

        }


        // setter for num1_real
        public void set_num1_real(float num1_real)
        {
            this.num1_real = num1_real;
        }


        // setter for num1_img
        public void set_num1_img(float num1_img)
        {
            this.num1_img = num1_img;
        }


        // setter for num2_real
        public void set_num2_real(float num2_real)
        {
            this.num2_real = num2_real;
        }


        // setter for num2_img
        public void set_num2_img(float num2_img)
        {
            this.num2_img = num2_img;
        }


        // getter for num1_real
        public float get_num1_real()
        {
            return this.num1_real;
        }


        // getter for num1_img
        public float get_num1_img()
        {
            return this.num1_img;
        }



        // getter for num2_real
        public float get_num2_real()
        {
            return this.num2_real;
        }


        // getter for num2_img
        public float get_num2_img()
        {
            return this.num2_img;
        }


        // setter for the math_symbol
        public void set_math_operator(string math_symbol)
        {
            this.math_operator = math_symbol;
        }


        // getter for the math_symbol
        public string get_math_operator()
        {
            return this.math_operator;
        }




        // validating the input for num1_real
        public bool validate_num1_real(string num1_real_str)
        {

            if (num1_real_str.Length >= 1)
            {

                this.try_parse = float.TryParse(num1_real_str, out this.num1_real);

                if (this.try_parse)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        // validating the input for num1_img
        public bool validate_num1_img(string num1_img_str)
        {
            this.try_parse = float.TryParse(num1_img_str, out this.num1_img);

            if(this.try_parse)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        // validating the input for num2_real
        public bool validate_num2_real(string num2_real_str)
        {
            this.try_parse = float.TryParse(num2_real_str, out num2_real);

            if(this.try_parse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        // validating the input for num2_img
        public bool validate_num2_img(string num2_img_str)
        {
            this.try_parse = float.TryParse(num2_img_str, out num2_img);

            if(this.try_parse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool validate_math_opeator(string math_operator_str)
        {
            if (math_operator_str == "+")
            {
                this.math_operator = math_operator_str;
                return true;
            }
            else if (math_operator_str == "-")
            {
                this.math_operator = math_operator_str;
                return true;
            }
            else if (math_operator_str == "*")
            {
                this.math_operator = math_operator_str;
                return true;
            }
            else if (math_operator_str == "/")
            {
                this.math_operator = math_operator_str;
                return true;
            }
            else if(math_operator_str == "%")
            {
                this.math_operator = math_operator_str;
                return true;
            }
            else
            {
                return false;
            }
        }



        // calculating and returning the result for the real number
        public float calc_real_num(float num1_real, float num2_real, string math_operator)
        {
            if(math_operator == "+")
            {
                return num1_real + num2_real;
            }
            else if(math_operator == "-")
            {
                return num1_real - num2_real;
            }
            else if(math_operator == "*")
            {
                return num1_real * num2_real;
            }
            else if(math_operator == "/")
            {
                return num1_real / num2_real;
            }
            else if(math_operator == "%")
            {
                return num1_real % num2_real;
            }
            else
            {
                return 0;
            }
        }


        // calculating and returning the result for the imaginary number
        public float calc_img_num(float num1_img, float num2_img, string math_operator)
        {
            if (math_operator == "+")
            {
                return num1_img + num2_img;
            }
            else if (math_operator == "-")
            {
                return num1_img - num2_img;
            }
            else if (math_operator == "*")
            {
                return num1_img * num2_img;
            }
            else if (math_operator == "/")
            {
                return num1_img / num2_img;
            }
            else if (math_operator == "%")
            {
                return num1_img % num2_img;
            }
            else
            {
                return 0;
            }
        }




    }
}
