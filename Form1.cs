using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryDesignSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string GetOpertionVal()
        {
            string sValue = "";
            if(rbAddition.Checked==true)
            {
                sValue = "Addition";
            }
            else if (rbSubtraction.Checked==true)
            {
                sValue = "Subtraction";
            }
            else if (rbMultiplication.Checked == true)
            {
                sValue = "Multiplication";
            }
            else if (rbDivision.Checked == true)
            {
                sValue = "Division";
            }
            return sValue;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double num1 =Convert.ToDouble(txtNum1.Text);
            double num2 =Convert.ToDouble(txtNum2.Text);

            Factory objF = new Factory();
            ICalculate objIC = objF.GetCalculation(GetOpertionVal());
            label3.Text = "The result is " +objIC.calculate(num1, num2).ToString();
        }

        
    }
}
