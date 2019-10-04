using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE.SQAT.CalculatorApp
{
    public class Calculator
    {
        double currentValue = 0;
        string operation = "";
        public double Display { get { return currentValue;} set { currentValue = value; } }
        public double PressEnter()
        {
            return currentValue;
        }
        public void PressDisplay(object value)
        {
            
            {
                if (operation != "")
                    Calculate(Convert.ToDouble(value));
                else
                {
                    currentValue = Convert.ToDouble(value);
                }
            }
        }
        public void PressPlus()
        {
            operation = "+";
        }
        public void PressMinus()
        {
            operation = "-";
        }
        public void PressMultiply()
        {
            operation = "*";
        }
        public void PressDivide()
        {
            operation = "/";
        }
        void Calculate(double value)
        {
            switch(operation){
                case "-":
                    currentValue -= value;
                    break;
                case "+":
                    currentValue += value;
                    break;
                case "/":
                    if (value == 0)
                        throw new DivideByZeroException();
                    currentValue /= value;
                    break;
                case "*":
                    currentValue *= value;
                    break;
            }
            operation = "";
        }
    }
}
