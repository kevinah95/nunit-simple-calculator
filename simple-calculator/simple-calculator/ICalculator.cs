using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    interface ICalculator
    {
        double Add(double pFirstNumber, double pSecondNumber);
        double Sub(double pFirstNumber, double pSecondNumber);
        double Mul(double pFirstNumber, double pSecondNumber);
        double Div(double pFirstNumber, double pSecondNumber);
    }
}
