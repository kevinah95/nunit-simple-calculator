using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Calculator : ICalculator
    {
        public double result { get; private set; } = 0;

        public double Add(double pFirstNumber, double pSecondNumber)
        {
            result = pFirstNumber + pSecondNumber;
            return result;
        }

        public double Sub(double pFirstNumber, double pSecondNumber)
        {
            result = pFirstNumber - pSecondNumber;
            return result;
        }

        public double Mul(double pFirstNumber, double pSecondNumber)
        {
            result = pFirstNumber * pSecondNumber;
            return result;
        }

        public double Div(double pFirstNumber, double pSecondNumber)
        {
            if (pSecondNumber == 0)
                throw new DivideByZeroException();
            result = pFirstNumber / pSecondNumber;
            return result;
        }

        public double ConvertToValidInput(string pFactor)
        {
            try
            {
                var resultado = double.Parse(pFactor);
                return resultado;
            }
            catch (FormatException)
            {
                return 0;
            }
        }

    }
}
