using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorMain : Form
    {
        CalculatorFunction calculatorFunction = new CalculatorFunction();
        public CalculatorMain()
        {
            InitializeComponent();
            txtresult.Text = "0";
            //For Keyboard Pressing
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(CalculatorMain_KeyPressed);
            this.KeyDown += new KeyEventHandler(CalculatorMain_KeyDown); 

            lbHistory.DrawItem += new DrawItemEventHandler(lbhistory_DrawItem);
            lbHistory.ItemHeight = 25;
        }
        //KeyPress for 0-9 button and operators
        private void CalculatorMain_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.') // Allow numbers from 0 to 9
            {
                Button numberButton = new Button();
                numberButton.Text = e.KeyChar.ToString();
                NumValue_Click(numberButton, e); // Call the existing number handler for input validation
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/') // Allow basic operators (+, -, *, /)
            {
                Button operatorButton = new Button();
                operatorButton.Text = e.KeyChar.ToString();
                OperatorValue_Click(operatorButton, e); // Call the existing operator handler for input validation
            }
            else if (e.KeyChar == '=' || e.KeyChar == (char)Keys.Enter) // Allow equal sign or Enter key to perform calculation
            {
                Equals_Click(sender, e); // Call the equals button handler for calculation
            }
            else if(e.KeyChar == (char)Keys.Back)
            {
                BackSpace_Click(sender, e);
            }
            else if(e.KeyChar == 'c')
            {
                ClearAll_Click(sender, e);
            }
            else if(e.KeyChar == 'h')
            {
                btnHistory_Click_1(sender, e);
            }
            else // Disallow any other characters
            {
                e.Handled = true; // Ignore invalid input
            }
        }
        //Combination keys for percentage
        private void CalculatorMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D5 && e.Shift)
                btnPercent_Click(btnPercent, EventArgs.Empty);
        }
        //Holder or the one who gets the value of decimal and numbers 0-9
        private void NumValue_Click(object sender, EventArgs e)
        {
            Button numValue = (Button)sender;

            if (txtresult.Text == "Cannot be divided by 0")
            {
                ResetCalculator();
            }
            //Equal Handler
            if (calculatorFunction.IsEqualClick) 
            {
               ResetCalculator();
            }
            // Operator Handler
            if (calculatorFunction.IsOperatorClick)
            {
                txtresult.Clear();
                calculatorFunction.IsOperatorClick = false;
            }
            // Changing the values when the first value is 0 and without decimal 
            if (numValue.Text != "0" && !calculatorFunction.IsZeroHandle)
            {
                txtresult.Clear();
                calculatorFunction.IsZeroHandle = true;
            }
            //
            if(txtresult.Text == "" && numValue.Text == ".")
            {
                txtresult.Text = "0" + numValue.Text;
            }
            // Decimal Handler - Checks if the txtresult already contains decimal point you can't add another decimal point
            // Prevent adding another decimal point if one already exists
            string currentValue = txtresult.Text.Split(new char[] { '+', '-', '*', '/' }).Last();
            if (numValue.Text == "." && currentValue.Contains("."))
            {
                return;
            }
            //Zero Handler - You can't add multiple 0
            if (numValue.Text == "0" && currentValue == "0") return;

            txtresult.Text += numValue.Text;
        }
        private void OperatorValue_Click(object sender, EventArgs e)
        {
            Button operatorValue = (Button)sender;
            if(txtresult.Text == "Cannot be divided by 0")
            {
                ResetCalculator();
                return;
            }
            if (calculatorFunction.IsEqualClick)
            {
                txtDisplay.Clear();
                calculatorFunction.IsEqualClick = false;
            }
            //Append the value to txtDisplay
            if (calculatorFunction.IsOperatorClick)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1) + operatorValue.Text;
                return;
            }
            //Replacing the existing last operator with the new operator 
            if (calculatorFunction.IsLastCharOperator(txtresult.Text))
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1) + operatorValue.Text;
                return;
            }
            txtDisplay.Text += " " + txtresult.Text + " " + operatorValue.Text;
            calculatorFunction.IsOperatorClick = true;
            calculatorFunction.IsZeroHandle = false;
            calculatorFunction.IsCompute = false;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            string result;
            
            if (calculatorFunction.IsCompute) { return; }
            
            if (!calculatorFunction.IsEqualClick)
            {
                txtDisplay.Text += " " + txtresult.Text + " ";
                calculatorFunction.IsEqualClick = true;
            }
            
            string trimmedExpression = calculatorFunction.TrimExpression(txtDisplay.Text);
            result = calculatorFunction.solveExpression(trimmedExpression );
            calculatorFunction.IsOperatorClick = false;
            calculatorFunction.IsCompute = true;

            // For Adding expression and result in the history
            string finalResult = result;

            if (result == "Cannot be divided by 0")
            {
                txtresult.Text = result;
            }
            //for adding comma
            else
            {
                double parsedResult;
                if (double.TryParse(result, out parsedResult))
                {
                    //It checks if parsedResult is an integer if true then it will use N0 format, if false it uses custom format
                    txtresult.Text = parsedResult.ToString(parsedResult % 1 == 0 ? "N0" : "#,0.######");
                }
                else
                {
                    txtresult.Text = result;
                }
            }
            
            if (txtresult.Text != "Cannot be divided by 0")
            {
                if (lbHistory.Items.Count == 0 || lbHistory.Items[lbHistory.Items.Count - 2].ToString() != trimmedExpression)
                {
                    lbHistory.Items.Add(txtDisplay.Text + " ="); // Add expression
                    lbHistory.Items.Add(finalResult); // Add result on a new line
                    lbHistory.Items.Add(""); // Add blank line for separation
                }
            }
        }
        //Clear Button
        private void ClearAll_Click(object sender, EventArgs e)
        {
            ResetCalculator();
        }
        //Refresh the
        private void ResetCalculator()
        {
            txtDisplay.Clear();
            txtresult.Text = "0";
            calculatorFunction.IsZeroHandle = false;
            calculatorFunction.IsOperatorClick = false;
            calculatorFunction.IsEqualClick = false;
            calculatorFunction.IsCompute = false;
        }
        //BackSpace Button
        private void BackSpace_Click(object sender, EventArgs e)
        {
            //Checking if the textbox is not empty
            if (txtresult.Text.Length > 0)
            {
                txtresult.Text = txtresult.Text.Remove(txtresult.Text.Length - 1, 1);
            } 
            //If textbox is empty or 0. Clear all boolean methods and refresh to its original value.
            if (txtresult.Text == "0" || txtresult.Text == "")
            {
                ResetCalculator();
            }
        }
        //Percentage Button
        private void btnPercent_Click(object sender, EventArgs e)
        {
            // Convert the current result to a double
            double currentValue;
            // Try to parse the current result from the text box
            if (double.TryParse(txtresult.Text, out currentValue))
            {
                // Calculate the percentage
                double percentageValue = currentValue / 100;
                // Update the result textbox with the percentage
                txtresult.Text = percentageValue.ToString("0.#################"); // Format the output
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Design of my History
        private void lbhistory_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            string text = lbHistory.Items[e.Index].ToString();

            if (string.IsNullOrWhiteSpace(text))
                return;

            bool isResult = double.TryParse(text.Trim(), out _);

            // Use the new font and sizes
            using (Font expressionFont = new Font("Roboto", 14, FontStyle.Regular))  // Updated to Roboto
            using (Font resultFont = new Font("Roboto", 16, FontStyle.Bold))        // Updated to Roboto
            {
                SizeF textSize = e.Graphics.MeasureString(text, isResult ? resultFont : expressionFont);
                float rightAlignX = e.Bounds.Right - textSize.Width - 10;

                // Change text color for better contrast
                Brush textBrush = new SolidBrush(isResult ? Color.Black : Color.FromArgb(132, 60, 84)); // #843c54

                e.Graphics.DrawString(text, isResult ? resultFont : expressionFont, textBrush, rightAlignX, e.Bounds.Top);
            }
            e.DrawFocusRectangle();
        }

        private void btnHistory_Click_1(object sender, EventArgs e)
        {
            lbHistory.Visible = !lbHistory.Visible;
        }
    }
}
