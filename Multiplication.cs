using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignSample
{
    class Multiplication : ICalculate
    {
        public double calculate(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
