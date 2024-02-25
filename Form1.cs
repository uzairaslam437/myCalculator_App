using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics;


namespace MyCalculator
{
    public partial class Form1 : Form
    {
        private List<string> originalExpressionHistory = new List<string>();
        private List<string> expressionHistory = new List<string>();
        private double memoryValue = 0;
        private Color backgroundColor;
        private Color textColor;
        // Define a node to store both the expression and its result
     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "0" && !richTextBox1.Text.StartsWith("0.") && !richTextBox1.Text.StartsWith("-0."))
            {
                richTextBox1.Text += "0";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "*";
            }
            else
            {
                richTextBox1.Text += "*";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "%";
            }
            else
            {
                richTextBox1.Text += "%";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void button27_Click(object sender, EventArgs e) 
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = ".";
            }
            else
            {
                richTextBox1.Text += ".";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "+";
            }
            else
            {
                richTextBox1.Text += "+";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "-";
            }
            else
            {
                richTextBox1.Text += "-";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "/";
            }
            else
            {
                richTextBox1.Text += "/";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "√";
            }
            else
            {
                richTextBox1.Text += "√";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "!";
            }
            else
            {
                richTextBox1.Text += "!";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "(";
            }
            else
            {
                richTextBox1.Text += "(";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = ")";
            }
            else
            {
                richTextBox1.Text += ")";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "sin(";
            }
            else
            {
                richTextBox1.Text += "sin(";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "tan(";
            }
            else
            {
                richTextBox1.Text += "tan(";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "cos(";
            }
            else
            {
                richTextBox1.Text += "cos(";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "^";
            }
            else
            {
                richTextBox1.Text += "^";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "ln(";
            }
            else
            {
                richTextBox1.Text += "ln(";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "log(";
            }
            else
            {
                richTextBox1.Text += "log(";
            }
        }
        private int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = ".";
            }
            else
            {
                richTextBox1.Text += ".";
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming richTextBox1 is the name of your RichTextBox control
                string expression = richTextBox1.Text;

                // Handle special operations before parsing
                expression = HandleSpecialOperations(expression);

                // Parse the expression
                SymbolicExpression symbolicExpression = SymbolicExpression.Parse(expression);

                // Create a dictionary to hold the values of symbols
                var symbols = new Dictionary<string, FloatingPoint>();

                // Evaluate the expression by passing the symbols dictionary
                var result = symbolicExpression.Evaluate(symbols);
                // Add expression and result to the history
                expressionHistory.Add(richTextBox1.Text + " = " + result.RealValue);

                richTextBox1.Text = result.RealValue.ToString() ;

                

                // Update the display
                UpdateHistoryDisplay();
            }
            catch (Exception ex)
            {
                // Handle any exceptions, e.g., invalid input or unsupported operations
                richTextBox1.Text = "Error: " + ex.Message;
            }

        }
        private string HandleSpecialOperations(string expression)
        {
            // Handle % operation
            // Handle % operation
            expression = expression.Replace("%", "/100");

            // Handle factorial operation (e.g., 5!)
            expression = Regex.Replace(expression, @"(\d+)!", match => Factorial(int.Parse(match.Groups[1].Value)).ToString());

            // Handle common log operation (e.g., log10(x))
            expression = Regex.Replace(expression, @"log\((.*?)\)", match =>
            {
                double argument = double.Parse(match.Groups[1].Value);
                return Math.Log10(argument).ToString();
            });

            // Handle square root operation (e.g., sqrt(x))
            expression = Regex.Replace(expression, "√([0-9]+)", match =>
            {
                double number = double.Parse(match.Groups[1].Value);
                return Math.Sqrt(number).ToString();
            });

            return expression;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }


        private void button11_Click(object sender, EventArgs e)
        {
            // Convert the display text to a double
            if (double.TryParse(richTextBox1.Text, out double currentValue))
            {
                // Subtract the current value from the memory value
                memoryValue -= currentValue;
            }

            // Optionally, update your display or perform any other actions
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Convert the display text to a double
            if (double.TryParse(richTextBox1.Text, out double currentValue))
            {
                // Add the current value to the memory value
                memoryValue += currentValue;
            }

            // Optionally, update your display or perform any other actions
        }

        private void button36_Click(object sender, EventArgs e)
        {
            // Display the value stored in memory in the calculator's display
            richTextBox1.Text = memoryValue.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Clear the memory by setting it to 0
            memoryValue = 0;

            // Optionally, update your display or perform any other actions
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Convert the display text to a double
            if (double.TryParse(richTextBox1.Text, out double currentValue))
            {
                // Store the current value in memory
                memoryValue = currentValue;
            }

            // Optionally, update your display or perform any other actions
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void UpdateHistoryDisplay()
        {
            // Clear the existing text in richTextBox2
            richTextBox2.Clear();

            // Append each entry from the history to richTextBox2
            foreach (string entry in expressionHistory)
            {
                richTextBox2.AppendText(entry + Environment.NewLine);
            }
        }

        private void SetTheme(Color backgroundColor, Color buttonColor, Color buttonTextColor)
        {
            // Set background color
            this.BackColor = backgroundColor;

            // Loop through all controls to find buttons and set their colors
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.BackColor = buttonColor;
                    button.ForeColor = buttonTextColor;
                }
            }
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (themeToolStripMenuItem.Text == "Dark Theme")
            {
                SetTheme(Color.Black, Color.DarkGray, Color.White);
                themeToolStripMenuItem.Text = "Light Theme";
            }
            else
            {
                SetTheme(Color.White, SystemColors.Control, SystemColors.ControlText);
                themeToolStripMenuItem.Text = "Dark Theme";
            }
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color buttonColor = colorDialog.Color;

                // Loop through all controls to find buttons and set their colors
                foreach (Control control in this.Controls)
                {
                    if (control is Button)
                    {
                        Button button = (Button)control;
                        button.BackColor = buttonColor;
                    }
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
