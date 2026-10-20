using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg,T arg2);
    class CalculatorClass
    {
        public Formula<double> formula;
        public double GetSum(double firstNum, double secondNum){
            return firstNum + secondNum; 
        }
        public double GetDifference(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public double GetProduct(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public double GetQuotient(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
        public event Formula<double> CalculateEvent {
            add { 
                Console.WriteLine("Adding The Delegate.");
                formula += value;
            }
            remove { 
                Console.WriteLine("Removed The Delegate.");
                formula -= value;
            }
                }
    }
}
