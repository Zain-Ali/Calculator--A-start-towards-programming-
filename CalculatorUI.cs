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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

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
            // to do
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            // to do

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
    }
}

