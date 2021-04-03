using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    class Is_Prime_class
    {

        // private integer to hold the user`s inpuit
        private int number;



        // default constructor
        public Is_Prime_class()
        {
            this.number = 0;   
        }



        // setter for the number
         public void set_number(int number)
        {

            this.number = number;
        }


        // getter for the number
        public int get_number()
        {
            return this.number;
        }



        // validating if the inputted number is a prime number
        public bool is_prime(int number)
        {
            if(number == 0 || number == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= number / 2; ++i)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }


                return true;
            }
        }



    }
}
