using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * @author Callum Goodreid
 * @Version 1.0
 * 23/03/2017
 * */
namespace project
{
    public partial class Form1 : Form
    {
        //define variables
        static double num1 = 0;
        static string check = "";

        public Form1()
        {
            InitializeComponent();
        }
        //click button for numbers
        private void btnNumbers_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "." && textBox1.Text.Contains("."))
            {
                return;
            }
            else
            {
                textBox1.Text += clickedButton.Text;
            }
            
        }
        //simple math buttons
        #region simple math buttons
            //Divide calculation
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (check == "")
            {            
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            check = "div";
            }
        }
        //multiplication calculator
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (check == "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                check = "times";
            }
        }
        //subtraction calculator
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (check == "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                check = "sub";
            }
        }
        //addition calculator
        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (check == "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                check = "plus";
            }
        }
        #endregion //ends simple math


 //does the calculation
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                switch (check)
                {
                    //checks if divsion
                    case "div":
                        num1 = BasicMath.Class1.Divide(num1, Convert.ToDouble(textBox1.Text));
                        break;
                    //checks if multiplication
                    case "times":
                        num1 = BasicMath.Class1.Multiply(num1, Convert.ToDouble(textBox1.Text));
                        break;
                    //checks if subtraction
                    case "sub":
                        num1 = BasicMath.Class1.sub(num1, Convert.ToDouble(textBox1.Text));
                        break;
                    //checks if addition
                    case "plus":
                        num1 = BasicMath.Class1.add(num1, Convert.ToDouble(textBox1.Text));
                        break;
                    //else error out
                    default:
                        textBox1.Text = "Error";
                        return;
                        //break;
                }
            }
            textBox1.Text = num1.ToString();
            check = "";


        }

        //Harder math functions
        #region hard math 
        //Calculates square root
        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num1 = BasicMath.Class1.SqrRoot(num1);
                textBox1.Text = num1.ToString();
            }
        }
        //calculates cube root
        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num1 = BasicMath.Class1.CubeRoot(num1);
                textBox1.Text = num1.ToString();
            }
        }
        //inverses the number
        private void btnInverse_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num1 = BasicMath.Class1.inverse(num1);
                textBox1.Text = num1.ToString();
            }
        }

        //calculates the tan on radian
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num1 = BasicMath.Class1.tan(num1);
                textBox1.Text = num1.ToString();
            }
        }
        //calculates the sin on radian
        private void btnSin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num1 = BasicMath.Class1.sin(num1);
                textBox1.Text = num1.ToString();

            }
        }
        //calculates the cos on radian
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                num1 = Convert.ToDouble(textBox1.Text);
                num1 = BasicMath.Class1.cos(num1);
                textBox1.Text = num1.ToString();
            }

        }
        #endregion

        //clears all information
        private void btnAC_Click(object sender, EventArgs e)
        {
            num1 = 0;
            textBox1.Clear();
            check = "";
        }
    }
}
