using System;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public class CalculatorButton : Button
    {
        public string ButtonType { get; set; }
        private Calculator calculator;

        public CalculatorButton()
        {
            
        }

        public void SetCalculator(Calculator calculator)
        {
            this.calculator = calculator;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            var highlightedButtonBitmap = new Bitmap(Properties.Resources.highlightedButton);
            this.BackgroundImage = highlightedButtonBitmap;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            var buttonBitmap = new Bitmap(Properties.Resources.button);
            this.BackgroundImage = buttonBitmap;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            ButtonType = this.Text;

            if (calculator != null)
            {
                if (int.TryParse(ButtonType, out _) || ButtonType == ".")
                {
                    calculator.TypeNumber(this);
                }
                else if (ButtonType == "+/-")
                {
                    calculator.SignNumber();
                }
                else if (calculator.Operators.Contains(ButtonType))
                {
                    calculator.PerformOperation(this);
                }
                else
                {
                    calculator.ClearOperation(this);
                }
            }
        }
    }
}
