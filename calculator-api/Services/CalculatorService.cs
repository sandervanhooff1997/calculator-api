using System;
namespace calculator_api.Services
{
    public class CalculatorService : BaseService
    {
        private readonly int decimals = 10;
            
        public CalculatorService()
        {

        }

        public Sum Calculate(decimal num1, decimal num2, string operatorString)
        {
            var sum = new Sum()
            {
                Num1 = num1,
                Num2 = num2,
                OperatorString = operatorString
            };

            switch (operatorString)
            {
                case "+":
                    sum.Answer = Math.Round(Add(num1, num2), decimals);
                    break;
                case "-":
                    sum.Answer = Math.Round(Subtract(num1, num2), decimals);
                    break;
                case "*":
                    sum.Answer = Math.Round(Multiply(num1, num2), decimals);
                    break;
                case "/":
                    sum.Answer = Math.Round(Devide(num1, num2), decimals);
                    break;
                default: throw new Exception($"Operator {operatorString} niet ondersteund.");
            }

            logService.Log(sum.ToString());

            return sum;
        }

        private decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        private decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        private decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        private decimal Devide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
