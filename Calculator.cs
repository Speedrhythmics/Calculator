using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

            if (int.TryParse(button.ButtonType, out _))
            {
                string text = button.ButtonType;
                int typedNumber = Convert.ToInt32(text);
                switch (typedNumber)
                {
                    case 0:
                        if (!TextIsZero())
                        {
                            inputBox.Text += text;
                            operationDisplay.Text += text;
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
            else if (!inputBox.Text.Contains("."))
            {     
                inputBox.Text += ".";
                operationDisplay.Text += ".";
            }
        }
        public void TypeNumber(string number)
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
            if (number != ".")
            {
                int typedNumber = Convert.ToInt32(number);
                switch (typedNumber)
                {
                    case 0:
                        if (!TextIsZero())
                        {
                            inputBox.Text += number;
                            operationDisplay.Text += number;
                        }
                        break;
                    default:
                        if (TextIsZero())
                        {
                            inputBox.Text = number;
                            operationDisplay.Text = number;
                        }
                        else
                        {
                            inputBox.Text += number;
                            operationDisplay.Text += number;
                        }
                        break;
                }
            }
            else if (!inputBox.Text.Contains("."))
            {
                inputBox.Text += number;
                operationDisplay.Text += number;
            }
        }
        public void PerformOperation(CalculatorButton button)
        {
            if (resultDisplaying)
            {
                operand = result;
                operationDisplay.Text = $"{operand}";
                resultDisplaying = false;
            }

            double temp = 0;
            operandLength = 0;
            if (Operators.Contains(button.ButtonType) && double.TryParse(inputBox.Text, out _))
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
        public void PerformOperation(string passedOperator)
        {
            if (resultDisplaying)
            {
                operand = result;
                operationDisplay.Text = $"{operand}";
                resultDisplaying = false;
            }

            double temp = 0;
            operandLength = 0;
            if (Operators.Contains(passedOperator) && double.TryParse(inputBox.Text, out _))
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
                if (passedOperator != "=")
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

            operationDisplay.Text += $" {passedOperator} ";
            switch (passedOperator)
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
        public void SignNumber()
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
                    if (!resultDisplaying)
                    {
                        if (operandLength > 0)
                        {
                            inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
                            operationDisplay.Text = operationDisplay.Text.Substring(0, operationDisplay.Text.Length - 1);
                            operandLength--;
                        }
                    }
                    break;
            }
        }
        public void ClearOperation(string clearOperation)
        {
            switch (clearOperation)
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
                    if (!resultDisplaying)
                    {
                        if (operandLength > 0)
                        {
                            inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
                            operationDisplay.Text = operationDisplay.Text.Substring(0, operationDisplay.Text.Length - 1);
                            operandLength--;
                        }
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
            operationDisplay.Text = displayText.Substring(0, displayText.Length - operandLength);
        }
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Shift)
            {
                switch (e.KeyCode)
                {
                    //Operators
                    case Keys.D8:
                        PerformOperation("*");
                        break;
                    case Keys.Oemplus:
                        PerformOperation("+");
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    //Numbers
                    case Keys.D0:
                        TypeNumber("0");
                        break;
                    case Keys.D1:
                        TypeNumber("1");
                        break;
                    case Keys.D2:
                        TypeNumber("2");
                        break;
                    case Keys.D3:
                        TypeNumber("3");
                        break;
                    case Keys.D4:
                        TypeNumber("4");
                        break;
                    case Keys.D5:
                        TypeNumber("5");
                        break;
                    case Keys.D6:
                        TypeNumber("6");
                        break;
                    case Keys.D7:
                        TypeNumber("7");
                        break;
                    case Keys.D8:
                        TypeNumber("8");
                        break;
                    case Keys.D9:
                        TypeNumber("9");
                        break;
                    //Operators
                    case Keys.Add:
                        PerformOperation("+");
                        break;
                    case Keys.Subtract:
                    case Keys.OemMinus:
                        PerformOperation("-");
                        break;
                    case Keys.Multiply:
                        PerformOperation("*");
                        break;
                    case Keys.Divide:
                    case Keys.Oem2:
                        PerformOperation("/");
                        break;
                    case Keys.Oemplus:
                    case Keys.Enter:
                        PerformOperation("=");
                        break;
                    //Decimal point
                    case Keys.OemPeriod:
                        TypeNumber(".");
                        break;
                    //Sign
                    case Keys.F9:
                        SignNumber();
                        break;
                    //Clear functions
                    case Keys.Escape:
                        ClearOperation("C");
                        break;
                    case Keys.Delete:
                        ClearOperation("CE");
                        break;
                    case Keys.Back:
                        ClearOperation("⌫");
                        break;
                }
            }
        }
    }
}
