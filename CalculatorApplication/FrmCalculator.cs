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
        CalculatorClass cal;

        public frmCalculator()
        {
            InitializeComponent();
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("x");
            cbOperator.Items.Add("/");
            cal = new CalculatorClass();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            double firstNum = Convert.ToDouble(txtBoxInput1.Text);
            double secondNum = Convert.ToDouble(txtBoxInput2.Text);
            string Caloperator = cbOperator.SelectedItem.ToString();

            switch (Caloperator) {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    lblAnswer.Text = cal.GetSum(firstNum, secondNum).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                    break;
                case "-":
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    lblAnswer.Text = cal.GetDifference(firstNum, secondNum).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                    break;
                case "x":
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    lblAnswer.Text = cal.GetProduct(firstNum, secondNum).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                    break;
                case "/":
                    cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                    lblAnswer.Text = cal.GetQuotient(firstNum, secondNum).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                    break;
                default:
                    lblAnswer.Text = "Invalid Operator";
                    break;
            }
        }
    }
}
