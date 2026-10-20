using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class frmCalculator : System.Windows.Forms.Form
    {
        Formula<double> getSum;
        Formula<double> getDifference;
        Formula<double> getProduct;
        Formula<double> getQuotient;

        CalculatorApplication cal;

        public frmCalculator()
        {
            InitializeComponent();
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("x");
            cbOperator.Items.Add("/");
            cal = new CalculatorApplication();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            getSum = new Formula<double>(CalculatorClass.getSum);
            getDifference = new Formula<double>(CalculatorClass.getDifference);
            getProduct = new Formula<double>(CalculatorClass.getProduct);
            getQuotient = new Formula<double>(CalculatorClass.getQuotient);
            double firstNum = Convert.ToDouble(txtBoxInput1.Text);
            double secondNum = Convert.ToDouble(txtBoxInput2.Text);
            string Caloperator = cbOperator.SelectedItem.ToString();

            switch (Caloperator) {
                case "+":
                    CalculatorApplication
                    lblAnswer.Text = getSum(firstNum, secondNum).ToString();
                    break;
                case "-":
                    lblAnswer.Text = getDifference(firstNum, secondNum).ToString();
                    break;
                case "x":
                    lblAnswer.Text = getProduct(firstNum, secondNum).ToString();
                    break;
                case "/":
                    lblAnswer.Text = getQuotient(firstNum, secondNum).ToString();
                    break;
                default:
                    lblAnswer.Text = "Invalid Operator";
                    break;
            }
            }
    }
}
