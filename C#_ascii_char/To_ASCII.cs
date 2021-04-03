using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_chars
{
    class To_ASCII
    {

        // private integer to hold the ascii number
        private int ascii_num;

        // private character to hold the ascii_character
        private char ascii_char;


        // default constructor
        public To_ASCII()
        {
            this.ascii_num = 0;
        }



        // setter for ascii_num
        public bool set_ascii_num(int ascii_num)
        {
            // validating the user`s input
            if(ascii_num >= 0 && ascii_num <=255)
            {
                this.ascii_num = ascii_num;
                return true;
            }
            else
            {
                return false;
            }

        }


        // getter for ascii_num
        public int get_ascii_num()
        {
            return this.ascii_num;
        }


        // converting the integer to ascii character
        public char convert_to_ascii_char(int ascii_num)
        {
            this.ascii_char = Convert.ToChar(ascii_num);
            return ascii_char;
            
        }



    }
}
