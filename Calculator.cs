using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            SetCalculatorInstances();
            LoadButtonTypeList();
        }

        public List<string> Operators;        
        private double result = 0;
        private double? operand = null;
        private enum Operation
        {
            None,
            Addition,
            Subtraction,
            Multiplication,
            Division
        }
        private int CurrentOperator = (int) Operation.None;
        private int operatorQuantity = 0;
        private int operandLength = 0;
        private bool TextIsZero()
        {
            return inputBox.Text == "0";
        }
        private bool resultDisplaying = false;
        private bool operandDisplaying = false;
        private void SetCalculatorInstances()
        {
            foreach (var button in this.Controls.OfType<CalculatorButton>())
            {
                button.SetCalculator(this);
            }
        }
        private void LoadButtonTypeList()
        {
            Operators = new List<string>()
            {
                "+",
                "-",
                "*",
                "/",
                "="
            };
        }      
        public void TypeNumber(CalculatorButton button)
        {
            operandLength++;
            if (resultDisplaying)
            {
                Clear();
                resultDisplaying = false;
            }

            if (operandDisplaying)
            {
                inputBox.Text = "";
                operandDisplaying = false;
            }

            string text = button.ButtonType;
            int typedNumber = Convert.ToInt32(text);
            switch (typedNumber)
            {
                case 0:
                    if (!TextIsZero())
                    {
                        inputBox.Text += text;
                    }
                    break;
                default:
                    if (TextIsZero())
                    {
                        inputBox.Text = text;
                    }
                    else
                    {
                        inputBox.Text += text;
                        operationDisplay.Text += text;
                    }
                    break;
            }
        }
        public void PerformOperation(CalculatorButton button)
        {
            double temp = 0;
            operandLength = 0;
            if (Operators.Contains(button.ButtonType))
            {
                temp = Convert.ToDouble(inputBox.Text);
            }
            switch (CurrentOperator)
            {
                //Addition.
                case 1:
                    operand += temp;
                    break;

                //Subtraction.
                case 2:
                    operand -= temp;
                    break;

                //Multiplication.
                case 3:
                    operand *= temp;
                    break;

                //Division.
                case 4:
                    operand /= temp;
                    break;
            }
            if (operatorQuantity > 0)
            {
                if (button.ButtonType != "=")
                {
                    operationDisplay.Text = $"{operand}";
                }
                operatorQuantity = 0;
            }
            if (operand == null)
            {
                operand = temp;
                if (!operandDisplaying && resultDisplaying)
                {
                    operationDisplay.Text = $"{operand}";
                }
            }

            operationDisplay.Text += $" {button.ButtonType} ";
            switch (button.ButtonType)
            {
                case "+":
                    CurrentOperator = (int)Operation.Addition;
                    break;
                case "-":
                    CurrentOperator = (int)Operation.Subtraction;
                    break;
                case "*":
                    CurrentOperator = (int)Operation.Multiplication;
                    break;
                case "/":
                    CurrentOperator = (int)Operation.Division;
                    break;
                case "=":
                    result = (double)operand;
                    inputBox.Text = result.ToString();
                    resultDisplaying = true;
                    ResetVariables();
                    break;
            }

            if (operand != null)
            {
                operatorQuantity++;
                inputBox.Text = operand.ToString();
                operandDisplaying = true;
            }
        }
        public void SignNumber(CalculatorButton button)
        {
            operandDisplaying = false;
            string number = inputBox.Text;
            if (number == "")
            {
                inputBox.Text += "-";
                operationDisplay.Text += "-";
            }
            else
            {
                string displayText = operationDisplay.Text;
                //If is negative
                if (number[0] == '-')
                {
                    number = number.Substring(1);
                    inputBox.Text = number;
                }
                //If isn't negative
                else
                {
                    inputBox.Text = "-";
                    RemoveLastNumberFromDisplay(operationDisplay.Text);
                    operationDisplay.Text += "-";
                    if (operandLength > 0)
                    {
                        operationDisplay.Text += number.ToString();
                        inputBox.Text += number.ToString();
                    }
                }
            }
        }
        public void ClearOperation(CalculatorButton button)
        {
            switch (button.ButtonType)
            {
                case "C":
                    Clear();
                    operandLength = 0;
                    break;
                case "CE":
                    RemoveLastNumberFromDisplay(operationDisplay.Text);
                    inputBox.Text = "";
                    operandLength = 0;
                    break;
                case "⌫":
                    string text = inputBox.Text;
                    string newText = text.Remove(text.Length - 1);
                    inputBox.Text = newText;
                    if (operandLength > 0)
                    {
                        operandLength--;
                    }
                    break;
            }
        }
        private void ResetVariables()
        {
            operatorQuantity = 0;
            operand = null;
            CurrentOperator = (int)Operation.None;
        }
        private void Clear()
        {
            ResetVariables();
            operationDisplay.Text = "";
            inputBox.Text = "";
            result = 0;
        }
        private void RemoveLastNumberFromDisplay(string displayText)
        {
            operationDisplay.Text = displayText.Substring(0, displayText.Length - (operandLength));
        }
    }
}
