using System;
using System.Globalization;

namespace calculator_api
{
    public class Sum
    {
        public decimal Num1 { get; set; }
        public decimal Num2 { get; set; }
        public string OperatorString { get; set; }
        public decimal Answer { get; set; }
        public string AnswerString
        {
            get {
                // comma seperated decimals
                return Answer.ToString(CultureInfo.CreateSpecificCulture("nl-NL"));
            }
        }

        public override string ToString()
        {
            return $"Sum {Num1} {OperatorString} {Num2} = {AnswerString}";
        }
    }
}
