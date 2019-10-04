using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE.SQAT.CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            while (true)
            {
                string value = Console.ReadLine();
                if (value == "+" || value == "/" || value == "*" || value == "-" || value == "=")
                {
                    switch (Convert.ToString(value))
                    {
                        case "+":
                            calculator.PressPlus();
                            break;
                        case "-":
                            calculator.PressMinus();
                            break;
                        case "*":
                            calculator.PressMultiply();
                            break;
                        case "/":
                            calculator.PressDivide();
                            break;
                        case "=":
                            Console.WriteLine(calculator.PressEnter());
                            break;
                    }
                }
                else
                {
                    calculator.PressDisplay(value);
                }
            }
        }
    }
}
