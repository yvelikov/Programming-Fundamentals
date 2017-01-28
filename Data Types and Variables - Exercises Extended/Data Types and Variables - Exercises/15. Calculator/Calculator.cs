using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int leftOperand = int.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine());
            int rightOperand = int.Parse(Console.ReadLine());
            int result = 0;
            switch (mathOperator)
            {
                case '+':
                    result = leftOperand + rightOperand;
                    break;
                case '-':
                    result = leftOperand - rightOperand;
                    break;
                case '*':
                    result = leftOperand * rightOperand;
                    break;
                case '/':
                    result = leftOperand / rightOperand;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
