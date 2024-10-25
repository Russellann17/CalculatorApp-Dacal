using System;
using System.Data;

namespace CalculatorApp
{
    public class CalculatorFunction
    {
        public bool IsEqualClick { get; set; } = false;
        public bool IsOperatorClick { get; set; } = false;
        public bool IsZeroHandle { get; set; } = false;
        public bool IsCompute { get; set; } = false;

        //Check if the last character is an operator
        //For Replacing the existing operator with the new operator
        public bool IsLastCharOperator(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            string trimExpression = value.Trim();
            char lastChar = trimExpression[trimExpression.Length - 1];

            return lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/';
        }

        //Trim or Remove the spaces
        public string TrimExpression(string displayValue)
        {
            displayValue = displayValue.Replace(",","");
            return displayValue.Replace(" ", "");
        }

        //Solving the expression
        public string solveExpression(string trimExpression)
        {
            if (trimExpression.Contains("/0"))
            {
                return "Cannot be divided by 0";
            }
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(trimExpression, string.Empty);
                return result.ToString();
            }
            catch (OverflowException)
            {
                return "Too large to compute";
            }
        }
    }
}
