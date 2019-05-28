using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int mul = firstNumber * secondNumber;
            resultTextBox.Text = mul.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sum = firstNumber + secondNumber;
            resultTextBox.Text=sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sub = firstNumber - secondNumber;
            resultTextBox.Text = sub.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int div = firstNumber / secondNumber;
            resultTextBox.Text = div.ToString();
        }
    }
}
