using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using mathi
namespace Calcuator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            Focusing();                                                     //creating a method call Fucusing()
        }
        
        private void Focusing()                                             //method created
        {
            txtDisplay.Focus();
        }

        private void btnOne_Click(object sender, EventArgs e)                       // button one
        {
            txtDisplay.Text+= btnOne.Text ;                                         // to allow users click several times
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnTwo.Text;                                         // to allow users click several times
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnThree.Text;                                         // to allow users click several times
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFour.Text;                                         // to allow users click several times
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFive.Text;                                         // to allow users click several times
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSix.Text;                                         // to allow users click several times
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSeven.Text;                                         // to allow users click several times
        }


        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnEight.Text;                                         // to allow users click several times
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNine.Text;                                         // to allow users click several times   
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnZero.Text;                                         // to allow users click several times

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = btnPoint.Text;
        }

        private void button18_Click(object sender, EventArgs e)                         // to clear all the entries
        {
            txtDisplay.Clear();
        }

        private void btnClearEntries_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
        }

        double number1, number2, Answer;
        bool Addition = false;
        bool Multiplication = false;
        bool Subtraction = false;
        bool Division = false;
        bool SquareRoot = false;
        bool Power = false;
        bool Combination = false;
        bool Permutation = false;
        private void btnAddition_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            Addition = true;
            Multiplication = false;
            Subtraction = false;
            Division = false;
            Power = false;
            bool Combination = false;
            bool Permutation = false;
            txtDisplay.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            Addition = false;
            Multiplication =true;
            Subtraction = false;
            Division = false;
            Power = false;
            bool Combination = false;
            bool Permutation = false;
            txtDisplay.Clear();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            Addition = false;
            Multiplication = false;
            Subtraction = true;
            Division = false;
            Power = false;
            bool Combination = false;
            bool Permutation = false;
            txtDisplay.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            Addition = false;
            Multiplication = false;
            Subtraction = false;
            Division = true;
            Power = false;
            bool Combination = false;
            bool Permutation = false;
            txtDisplay.Clear();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            Addition = false;
            Multiplication = false;
            Subtraction = false;
            Division = false;
            Power = true;
            bool Combination = false;
            bool Permutation = false;
            txtDisplay.Clear();
        }

        private void btnCombination_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            Addition = false;
            Multiplication = false;
            Subtraction = false;
            Division = false;
            Power = false;
            Combination = true;
            Permutation = false;
            txtDisplay.Clear();
        }

        private void btnPermuatation_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            Addition = false;
            Multiplication = false;
            Subtraction = false;
            Division = false;
            Power = false;
            Combination = false;
            Permutation = true;
            txtDisplay.Clear();
 
        }




        private void btnEqual_Click(object sender, EventArgs e)s
        {
            
            if (Addition)                                                           // when the module addition is correct
            {
                number2 = double.Parse(txtDisplay.Text);
                Answer = number1 + number2;
                txtDisplay.Text = Answer.ToString();                                    //converting from double to string
            }

            else if (Multiplication)
            {
                number2 = double.Parse(txtDisplay.Text);
                Answer = number1 * number2;
                txtDisplay.Text = Answer.ToString();
            }

            else if(Subtraction)
            {
                number2 = double.Parse(txtDisplay.Text);
                Answer = number1 - number2;
                txtDisplay.Text = Answer.ToString();
            }

            else if(Subtraction)
            {
                number2 = double.Parse(txtDisplay.Text);
                Answer = number1 - number2;
                txtDisplay.Text = Answer.ToString();
            }

            else if(Power)
            {
                number2 = int.Parse(txtDisplay.Text);
                Answer = Math.Pow(number1, number2);
                txtDisplay.Text = Answer.ToString();

            }

            else if(Combination)
            {
                float result1 = 1;
                float result2=1;
                float ans1, ans2;
              //  number1 = int.Parse(txtDisplay.Text);
                int i;
                result1 = 1;
                for (i = 1; i <= number1; i++)
                {
                    result1 *= i;
                }

                number2 = int.Parse(txtDisplay.Text);
          
                result2 = 1;
                for (i = 1; i <= number2; i++)
                {
                    result2 *= i;
                }
                ans1 = result1;
                ans2 = result2 * (result1 - result2);
                Answer = ans1 / ans2;
                txtDisplay.Text = Answer.ToString();
                




               // txtDisplay.Text = Answer.ToString();
            }
        }

        
        private void btnSquare_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(txtDisplay.Text);
            Answer=Math.Sqrt(number1);
            txtDisplay.Text=Answer.ToString();
        }

       
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(txtDisplay.Text);
            int i;
            Answer = 1;
            for (i = 1; i <= number1; i++)
            {
                Answer *= i;
            }
            txtDisplay.Text = Answer.ToString();
        }


      

       


        

    }
}

