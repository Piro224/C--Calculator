using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Calculator
{
    public partial class Form1 : Form
    {
        double firstNum, secondNum;
        string oper;


        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnPM_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(textBox.Text=="0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text = textBox.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text = textBox.Text + "1";

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";

            }
            else
            {
                textBox.Text = textBox.Text + "2";

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";

            }
            else
            {
                textBox.Text = textBox.Text + "3";

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";

            }
            else
            {
                textBox.Text = textBox.Text + "4";

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";

            }
            else
            {
                textBox.Text = textBox.Text + "5";

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";

            }
            else
            {
                textBox.Text = textBox.Text + "6";

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";

            }
            else
            {
                textBox.Text = textBox.Text + "7";

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";

            }
            else
            {
                textBox.Text = textBox.Text + "8";

            }
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";

            }
            else
            {
                textBox.Text = textBox.Text + "9";

            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
            if(textBox.Text=="")
            {
                textBox.Text = "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            oper = "+";
            textBox.Text = "";
            label2.Text = firstNum + "+";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            oper = "-";
            textBox.Text = "";
            label2.Text = firstNum + "-";

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            oper = "÷";
            textBox.Text = "";
            label2.Text = firstNum + "÷";

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            oper = "×";
            textBox.Text = "";
            label2.Text = firstNum + "×";

        }

        private void btnP_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            oper = "%";
            textBox.Text = "";
            label2.Text = firstNum + "%";

        }

        private void btnCL_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            label2.Text = "";

        }

        private void btnCLE_Click(object sender, EventArgs e)
        {
            textBox.Text="0";
            label2.Text = firstNum + "" + oper;

        }

        private void btnPM_Click_1(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox.Text);   
            textBox.Text = Convert.ToString(-1 * r);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            secondNum = double.Parse(textBox.Text);
            label2.Text = textBox.Text;
           

            switch (oper)
            {
                case "+":
                    textBox.Text = (firstNum + secondNum).ToString();
                    label2.Text = firstNum.ToString() +"+"+ secondNum.ToString();
                    break;
                case "-":
                    textBox.Text = (firstNum - secondNum).ToString();
                    label2.Text = firstNum.ToString() + "-" + secondNum.ToString();
                    break;
                case "÷":
                    textBox.Text = (firstNum / secondNum).ToString();
                    label2.Text = firstNum.ToString() + "÷" + secondNum.ToString(); 
                    break;
                case "×":
                    textBox.Text = (firstNum * secondNum).ToString();
                    label2.Text = firstNum.ToString() + "×" + secondNum.ToString(); 
                    break;
                    
                case "%":

                    /*this is the percentage operator and no longer modulus,
                     so it works like the normal eg. 10% of 200 giving you an answer
                     without including the multiply sign with it. */

                    textBox.Text = (firstNum % secondNum).ToString();
                    textBox.Text = (firstNum * 1/100 * secondNum).ToString(); 
                    label2.Text = firstNum.ToString() + "%" + secondNum.ToString(); 
                    break;
                    
                case "(":
                    /* this is the bracket sign which does multiplication but in brackets,
                       so it multiples the firstNum by the secondNum in brackets.
                       And its clicked once, so you input firstNUm then you click on the bracket btn 
                       for the bracket '(', then you input the secondNum, then equals for results. */

                    textBox.Text = (firstNum * secondNum).ToString();
                    label2.Text = firstNum.ToString() + "(" + secondNum.ToString()+")"; 
                    break;
                    
                case "^":

                    /*this is the 'exponent / to the power sign ^ so it takes the firstNum, 
                    exponent or raise to the power of secondNum, then apply the equals button for results. */

                    textBox.Text = Math.Pow(firstNum, secondNum).ToString();
                    label2.Text = firstNum.ToString() + "^" + secondNum.ToString();
                    break;
                    
                case "√":

                    /* this is a square root operator that works like;
                    first you click the square root sign and then you input any number and then the equal sign.*/

                    textBox.Text = (Math.Sqrt(secondNum)).ToString();
                    label2.Text =  "√" + secondNum.ToString();
                    break;
                default:
                    break;

            }
            
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLeftBracket_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            oper = "(";
            textBox.Text = "";
            label2.Text = firstNum + "(";
            
        }

        private void btnRightBracket_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            oper = "√";
            textBox.Text = "";
            label2.Text ="√";
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            oper = "^";
            textBox.Text = "";
            label2.Text = firstNum + "^";
        }

        private void btnDeci_Click(object sender, EventArgs e)
        {
           if(!textBox.Text.Contains("."))
            {
                textBox.Text += ".";

            }
            else
            {
                textBox.Text = textBox.Text;

            }
        }
    }


}

