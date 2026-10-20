using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg,T arg2);
    public class CalculatorClass
    {
        public Formula<double> Formula;
        public static double getSum(double firstNum, double secondNum){
            return firstNum + secondNum; 
        }
        public static double getDifference(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public static double getProduct(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public static double getQuotient(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
        public event Formula<double> CalculateEvent {
            add { 
                Console.WriteLine("Adding The Delegate.");
            }
            remove { 
                Console.WriteLine("Removed The Delegate.");
            }
                }
    }
}
