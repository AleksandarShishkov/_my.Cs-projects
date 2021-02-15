using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// <summary>
/// Class definition for the mathematical operations
/// </summary>
namespace Calculator
{


    public class Calc_operation
    {



        #region Calc properties


        /// <summary>
        /// Left side of the opration
        /// </summary>
        public string left_side_operation { get; set; }


        /// <summary>
        /// Right side of the opration
        /// </summary>
        public string right_side_operation { get; set; }



        /// <summary>
        /// The type of the opration
        /// </summary>
        public Operators operators { get; set; }


        /// <summary>
        /// The inner opration
        /// </summary>
        public Operators inner_operation { get; set; }


        #endregion




        #region constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Calc_operation()
        {

            // setting the string to an empty string
            this.left_side_operation = string.Empty;
            this.right_side_operation = string.Empty;
        }





        #endregion

    }
}
