using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        float number;
        float answer;
        int count;


        private void userInputTestBox_TextChanged(object sender, EventArgs e)
        {
            //to do
        }

        private void userInputTestBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar)) 
            {
                MessageBox.Show("Please only enter numbers");                   
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 0;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 1;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 2;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 3;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 4;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 5;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 6;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 7;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 8;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            userInputTestBox.Text = userInputTestBox.Text + 9;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button userPressedbuttonNmber = (Button)sender;
            userInputTestBox.Text = userInputTestBox.Text + userPressedbuttonNmber.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button userPressedbuttonOperator = (Button)sender;
            userInputTestBox.Text = userInputTestBox.Text + userPressedbuttonOperator.Text;
        }

        private void plusOperatorButton_Click(object sender, EventArgs e)
        {
            number = float.Parse(userInputTestBox.Text);
            userInputTestBox.Clear();
            userInputTestBox.Focus();
            count = 1;
        }

        private void minusOperatorButton_Click(object sender, EventArgs e)
        {
            number = float.Parse(userInputTestBox.Text);
            userInputTestBox.Clear();
            userInputTestBox.Focus();
            count = 2;
        }

        private void multiplyOperatorButton_Click(object sender, EventArgs e)
        {
            number = float.Parse(userInputTestBox.Text);
            userInputTestBox.Clear();
            userInputTestBox.Focus();
            count = 3;
        }

        private void divideOperatorButton_Click(object sender, EventArgs e)
        {
            number = float.Parse(userInputTestBox.Text);
            userInputTestBox.Clear();
            userInputTestBox.Focus();
            count = 1;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            compute(count);            
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    answer = number + float.Parse(userInputTestBox.Text);
                    userInputTestBox.Text = answer.ToString();
                    break;

                case 2:
                    answer = number - float.Parse(userInputTestBox.Text);
                    userInputTestBox.Text = answer.ToString();
                    break;

                case 3:
                    answer = number * float.Parse(userInputTestBox.Text);
                    userInputTestBox.Text = answer.ToString();
                    break;

                case 4:
                    answer = number / float.Parse(userInputTestBox.Text);
                    userInputTestBox.Text = answer.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userInputTestBox.Clear();
            count = 0;
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            if (number == 0 && userInputTestBox.TextLength > 0)
            {
                number = 0;
                userInputTestBox.Clear();
            }
            else if (number > 0 && userInputTestBox.TextLength > 0)
            {
                userInputTestBox.Clear();
            }
        }
    }
}

