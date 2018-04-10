using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class MyMath
    {
        double result;
        double operand1;
        double operand2;

        public void Multiply(double operand1, double operand2)
        {
            result = operand1 * operand2;
        }

        public void Divide(double operand1, double operand2)
        {
            result = operand1 / operand2;
        }

        public void Subtract(double operand1, double operand2)
        {
            result = operand1 - operand2;
        }

        public void Add(double operand1, double operand2)
        {
            result = operand1 + operand2;
        }

        public double getResult()
        {
            return result;
        }
    }
}
