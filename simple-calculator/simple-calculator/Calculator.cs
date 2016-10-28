using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    class Calculator : ICalculator
    {
        public double Add(double pFirstNumber, double pSecondNumber)
        {
            return pFirstNumber + pSecondNumber;
        }

        public double Sub(double pFirstNumber, double pSecondNumber)
        {
            return pFirstNumber - pSecondNumber;
        }

        public double Mul(double pFirstNumber, double pSecondNumber)
        {
            return pFirstNumber * pSecondNumber;
        }

        public double Div(double pFirstNumber, double pSecondNumber)
        {
            double result = pFirstNumber / pSecondNumber;
            if (double.IsInfinity(result))
                throw new DivideByZeroException(); // or a different exception type.
            return result;
        }

    }
}
