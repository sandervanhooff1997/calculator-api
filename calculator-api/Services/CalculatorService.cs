using System;
namespace calculator_api.Services
{
    public class CalculatorService
    {
        private readonly int decimals = 10;
            
        public CalculatorService()
        {

        }

        public decimal Calculate(decimal num1, decimal num2, string operatorString)
        {
            switch (operatorString)
            {
                case "+":
                    return Math.Round(Add(num1, num2), decimals);

                case "-":
                    return Math.Round(Subtract(num1, num2), decimals);

                case "*":
                    return Math.Round(Multiply(num1, num2), decimals);

                case "/":
                    return Math.Round(Devide(num1, num2), decimals);
            }

            throw new Exception($"Operator {operatorString} niet ondersteund.");
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
