using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_project
{
    internal class Square
    {


        // private ineteger for the square`s height
        private int height;

        // private integer for the square`s width
        private int width;


        // default construcot
        public Square()
        {
            this.height = 0;
            this.width = 0;
        }




        // setter for the height
        public bool set_height(int height)
        {
            if(height > 0)
            {
                this.height = height;
                return true;
            }
            else
            {
                return false;
            }
        }


        // setter for the width
        public bool set_width(int width)
        {
            if(width > 0)
            {
                this.width = width;
                return true;
            }
            else
            {
                return false;
            }
        }


        // getter for the height
        public int get_height()
        {
            return this.height;
        }


        // getter for the width
        public int get_width()
        {
            return this.width;
        }


        // returning a string with the drawn square
        public string print_square(int height, int width, string output_str)
        {
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    output_str += "# ";
                }

                output_str += '\n';
            }

            return output_str;
        }


    }
}
