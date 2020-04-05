using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignSample
{
    class Factory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;
            if (type.ToLower() == "addition")
            {
                obj = new Addition();
            }
            else if (type.ToLower() == "subtraction")
            {
                obj = new Subtraction();
            }
            else if (type.ToLower() == "multiplication")
            {
                obj = new Multiplication();
            }
            else if (type.ToLower() == "division")
            {
                obj = new Division();
            }
            else
            {
                Console.WriteLine("This operation is not supported");
            }
            return obj;
        }
    }
}
