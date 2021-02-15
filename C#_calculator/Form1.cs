using System;
using System.Windows.Forms;
using System.Linq;



namespace Calculator
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }


        // grouping the operators in a reagion
        #region Operators


        /// <summary>
        /// Method to clear the user`s input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {

            // clearing the user`s input
            this.UserInput.Text = string.Empty;


            // calling focusInput() method
            focusUserInput();
        }


        /// <summary>
        /// Method for displaying the percentage sign '%'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PercentButton_Click(object sender, EventArgs e)
        {

            // adding '%' to the string
            this.UserInput.Text += " % ";
        }


        /// <summary>
        /// Method for deleting the last character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DELButton_Click(object sender, EventArgs e)
        {

            // Validating whether there is a character to be deleted
            if (this.UserInput.Text.Length < 1)
                return;

            this.UserInput.Text = this.UserInput.Text.Substring(0, UserInput.Text.Length - 1);
        }

       

        /// <summary>
        /// Method for displaying multiplication sign '*'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiButton_Click(object sender, EventArgs e)
        {

            // adding '*' to the string
            this.UserInput.Text += " * ";
        }


        /// <summary>
        /// Method for displaying the division sign '/'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            // adding '/' to the string
            this.UserInput.Text += " / ";
        }

        /// <summary>
        /// Method for displaying equals sign '='
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultButton_Click(object sender, EventArgs e)
        {

            // calling calculate() method
            calculate();
        }


        /// <summary>
        /// Method for displaying substraction sign '-'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubstrButton_Click(object sender, EventArgs e)
        {

            // adding '-' to the string
            this.UserInput.Text += " - ";
        }


        /// <summary>
        /// Method for displaying addition sign '+'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {

            // adding '+' to the string
            this.UserInput.Text += " + ";
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            // to be written
        }


        #endregion


        // grouping the calculator`s number in a region
        #region Numbers

        /// <summary>
        /// Method for displaying number '0'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {

            // adding '0' to the string
            this.UserInput.Text += "0";
        }


        /// <summary>
        /// Method for displaying number '1'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneButton_Click(object sender, EventArgs e)
        {

            // adding '1' to the string
            this.UserInput.Text += "1";
        }


        /// <summary>
        /// Method for displaying number '2'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoButton_Click(object sender, EventArgs e)
        {

            // adding '2' to the string
            this.UserInput.Text += "2";
        }


        /// <summary>
        /// Method for displaying number '3'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ThreeButton_Click(object sender, EventArgs e)
        {

            // adding '3' to the string
            this.UserInput.Text += "3";
        }


        /// <summary>
        /// Method for displaying number '4'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourButton_Click(object sender, EventArgs e)
        {

            // adding '4' to the string
            this.UserInput.Text += "4";
        }


        /// <summary>
        /// Method for displaying number '5'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveButton_Click(object sender, EventArgs e)
        {

            // adding '5' to the string
            this.UserInput.Text += "5";
        }


        /// <summary>
        /// Method for displaying number '6'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixButton_Click(object sender, EventArgs e)
        {

            // adding '6' to the string
            this.UserInput.Text += "6";
        }


        /// <summary>
        /// Method for displaying number '7'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SevenButton_Click(object sender, EventArgs e)
        {

            // adding '7' to the string
            this.UserInput.Text += "7";
        }


        /// <summary>
        /// Method for displaying number '8'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EightButton_Click(object sender, EventArgs e)
        {

            // adding '8' to the string
            this.UserInput.Text += "8";
        }


        /// <summary>
        /// Method for displaying number '9'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NineButton_Click(object sender, EventArgs e)
        {

            // adding '9' to the string
            this.UserInput.Text += "9";
        }



        /// <summary>
        /// Method for displaying decimal point notation '.'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButton_Click(object sender, EventArgs e)
        {

            // adding '.' to the string
            this.UserInput.Text += ".";
        }


        #endregion


        // groupint the helper methods into a region
        #region Helper methods


        /// <summary>
        /// Method for focusing the cursor in the text field
        /// </summary>
        private void focusUserInput()
        {

            // calling Focus() method
            this.UserInput.Focus();
        }

        private void ButtonsTable_Paint(object sender, PaintEventArgs e)
        {

        }


        /// <summary>
        /// Method for calculating the given equation and outputs the result
        /// </summary>
        private void calculate()
        {

            // assigning the current input into a string
            var input = this.UserInput.Text;

            // calling resOperation() method
            this.ResultOupput.Text = resOperation();
        }




        /// <summary>
        /// Method to calculate the result and to convert it into string
        /// </summary>
        /// <returns></returns>
        private string resOperation()
        {
            try
            {

                // take the user input
                var user = this.UserInput.Text;

                // removing the spaces
                user = user.Replace(" ", "");

                var operation = new Calc_operation();

                // setting a boolean for the left side of the operation to true
                var left_side = true;


                // looping trough each character from the left
                for (int i = 0; i < user.Length; ++i)
                {

                    // string containing the valid numeric values
                    var strNumbers = "0123456789.";

                    // string containing the valid math operations
                    var strMathOperations = "+-/*%";


                    // validating the input
                    if (strNumbers.Any(num => user[i] == num))
                    {
                        if (left_side)
                            operation.left_side_operation = AddPartNum(operation.left_side_operation, user[i]);
                        else
                            operation.right_side_operation = AddPartNum(operation.right_side_operation, user[i]);
                    }
                    else if(strMathOperations.Any(num=>user[i] == num))
                    {
                        if(!left_side)
                        {
                            var typeOperation = getTypeOperation(user[i]);

                                                       
                            if (operation.right_side_operation.Length == 0)
                            {
                                if (typeOperation != Operators.substract)
                                    throw new InvalidOperationException($"Invalid operator specified");

                                operation.right_side_operation += user[i];

                            }
                            else
                            {

                                operation.left_side_operation = calculate_operation(operation);
                                operation.operators = typeOperation;


                                operation.right_side_operation = string.Empty;

                            }

                        }
                        else
                        {
                            var typeOperation = getTypeOperation(user[i]);

                            if(operation.left_side_operation.Length == 0)
                            {
                                if (typeOperation != Operators.substract)
                                    throw new InvalidOperationException($"Invalid operator specified");

                                operation.left_side_operation += user[i];

                            }
                            else
                            {
                                operation.operators = typeOperation;

                                left_side = false;
                            }
                        }
                    }
                }


                // returning calculate_operation method
                return calculate_operation(operation);

                                                
                throw new ArgumentException("Invalid argument");
            }
            catch(Exception x)
            {
                return $"Invalid input. \n{x.Message}";
            }
        }




        /// <summary>
        /// Method for calculating the math expretion, returns the result  
        /// </summary>
        /// <param name="operation"></param>
        private string calculate_operation(Calc_operation operation)
        {
            double left = 0;
            double right = 0;

            // validating the inputted data

            if(string.IsNullOrEmpty(operation.left_side_operation)||!double.TryParse(operation.left_side_operation, out left))
            {
                throw new InvalidOperationException($"No number located on the left side of the equation. {operation.left_side_operation}");
            }

           
            if (string.IsNullOrEmpty(operation.right_side_operation) || !double.TryParse(operation.right_side_operation, out right))
                throw new InvalidOperationException($"No number located on the left side of the equation. {operation.right_side_operation}");

           

            try
            {

                switch(operation.operators)
                {

                    case Operators.add:
                        return (left + right).ToString();

                        break;


                    case Operators.substract:
                        return (left - right).ToString();

                        break;


                    case Operators.multiply:
                        return (left * right).ToString();

                        break;


                    case Operators.divide:
                        return (left / right).ToString();

                        break;


                    case Operators.percentage:
                        return (left % right).ToString();


                    default:
                        throw new InvalidOperationException($"Invalid math operation. {operation.operators}");

                        break;
                            
                        
                }

            }catch(Exception x)
            {
                throw new InvalidOperationException($"Invalid calculation. {operation.left_side_operation} " +
                    $"{operation.operators} {operation.right_side_operation}");
            }


            // returning empty string
            return string.Empty;

        }




        /// <summary>
        /// Method for character validation, adding it to the current number
        /// </summary>
        /// <param name="current_num"></param>
        /// <param name="current_char"></param>
        /// <returns></returns>
        private string AddPartNum(string current_num, char next_char)
        {
            if (next_char == '.' && current_num.Contains('.'))
                throw new InvalidOperationException($"{current_num} is already a real number");
            else
                return current_num += next_char;

        }




        /// <summary>
        /// Method for operator validation, returns the operator used if valid
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private Operators getTypeOperation(char user)
        {

            // switching the user
            switch (user)
            {
                case '+':
                    return Operators.add;

                    break;

                case '-':
                    return Operators.substract;

                    break;

                case '*':
                    return Operators.multiply;

                    break;

                case '/':
                    return Operators.divide;

                    break;

                case '%':
                    return Operators.percentage;

                    break;


                default:

                    // throwing exception if invalid operator
                    throw new InvalidOperationException($"Invalid operator used: {user}");
            }

        }





        #endregion

    }
}
