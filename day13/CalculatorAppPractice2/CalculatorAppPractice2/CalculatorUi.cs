using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
   

    public partial class CalculatorUi : Form
    {
        Calculator calculator;
        




        public CalculatorUi()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           int FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
           int SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);
           int Result=calculator.Add(FirstNumber,SecondNumber);
           resultTextBox.Text = Convert.ToString(Result);

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            int FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int Result = calculator.Subtract(FirstNumber, SecondNumber);
            resultTextBox.Text = Convert.ToString(Result);
             
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            int FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int Result = calculator.Multiplication(FirstNumber, SecondNumber);
            resultTextBox.Text = Convert.ToString(Result);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

            int FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int Result = calculator.Division(FirstNumber, SecondNumber);
            resultTextBox.Text = Convert.ToString(Result);
        }
    }
}
