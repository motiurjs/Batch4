using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    public class Calculator
    {
        


        public int Add(int FirstNumber,int SecondNumber)
        {
            return FirstNumber + SecondNumber; 
        }

        public int Subtract(int FirstNumber,int SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiplication(int FirstNumber, int SecondNumber)
        {
            return FirstNumber*SecondNumber;
        }

        public int Division(int FirstNumber, int SecondNumber)
        {
            return FirstNumber/SecondNumber;
        }
    }
}
