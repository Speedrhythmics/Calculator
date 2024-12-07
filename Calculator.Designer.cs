namespace Calculator
{
    public partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteButton = new CalculatorButton();
            this.number0 = new CalculatorButton();
            this.decimalButton = new CalculatorButton();
            this.signButton = new CalculatorButton();
            this.answerButton = new CalculatorButton();
            this.minusButton = new CalculatorButton();
            this.plusButton = new CalculatorButton();
            this.divideButton = new CalculatorButton();
            this.timesButton = new CalculatorButton();
            this.number1 = new CalculatorButton();
            this.number2 = new CalculatorButton();
            this.number3 = new CalculatorButton();
            this.number4 = new CalculatorButton();
            this.number5 = new CalculatorButton();
            this.number6 = new CalculatorButton();
            this.number7 = new CalculatorButton();
            this.number8 = new CalculatorButton();
            this.number9 = new CalculatorButton();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.clearEntryButton = new CalculatorButton();
            this.clearButton = new CalculatorButton();
            this.operationDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.ButtonType = null;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(240, 172);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 70);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "⌫";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // number0
            // 
            this.number0.BackColor = System.Drawing.Color.Transparent;
            this.number0.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number0.ButtonType = null;
            this.number0.FlatAppearance.BorderSize = 0;
            this.number0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number0.Location = new System.Drawing.Point(12, 400);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(70, 70);
            this.number0.TabIndex = 21;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = false;
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.Color.Transparent;
            this.decimalButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.decimalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decimalButton.ButtonType = null;
            this.decimalButton.FlatAppearance.BorderSize = 0;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(88, 400);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(70, 70);
            this.decimalButton.TabIndex = 20;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            // 
            // signButton
            // 
            this.signButton.BackColor = System.Drawing.Color.Transparent;
            this.signButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.signButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signButton.ButtonType = null;
            this.signButton.FlatAppearance.BorderSize = 0;
            this.signButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signButton.Location = new System.Drawing.Point(164, 400);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(70, 70);
            this.signButton.TabIndex = 19;
            this.signButton.Text = "+/-";
            this.signButton.UseVisualStyleBackColor = false;
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.Transparent;
            this.answerButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.answerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answerButton.ButtonType = null;
            this.answerButton.FlatAppearance.BorderSize = 0;
            this.answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.Location = new System.Drawing.Point(240, 400);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(94, 70);
            this.answerButton.TabIndex = 18;
            this.answerButton.Text = "=";
            this.answerButton.UseVisualStyleBackColor = false;
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Transparent;
            this.minusButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.minusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusButton.ButtonType = null;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(290, 340);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(44, 44);
            this.minusButton.TabIndex = 17;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Transparent;
            this.plusButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.plusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusButton.ButtonType = null;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(240, 340);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(44, 44);
            this.plusButton.TabIndex = 16;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.Transparent;
            this.divideButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.divideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.divideButton.ButtonType = null;
            this.divideButton.FlatAppearance.BorderSize = 0;
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(290, 264);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(44, 44);
            this.divideButton.TabIndex = 15;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            // 
            // timesButton
            // 
            this.timesButton.BackColor = System.Drawing.Color.Transparent;
            this.timesButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.timesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timesButton.ButtonType = null;
            this.timesButton.FlatAppearance.BorderSize = 0;
            this.timesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesButton.Location = new System.Drawing.Point(240, 264);
            this.timesButton.Name = "timesButton";
            this.timesButton.Size = new System.Drawing.Size(44, 44);
            this.timesButton.TabIndex = 14;
            this.timesButton.Text = "*";
            this.timesButton.UseVisualStyleBackColor = false;
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.Transparent;
            this.number1.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number1.ButtonType = null;
            this.number1.FlatAppearance.BorderSize = 0;
            this.number1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.Location = new System.Drawing.Point(12, 324);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(70, 70);
            this.number1.TabIndex = 12;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.Transparent;
            this.number2.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number2.ButtonType = null;
            this.number2.FlatAppearance.BorderSize = 0;
            this.number2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.Location = new System.Drawing.Point(88, 324);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(70, 70);
            this.number2.TabIndex = 11;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = false;
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.Transparent;
            this.number3.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number3.ButtonType = null;
            this.number3.FlatAppearance.BorderSize = 0;
            this.number3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3.Location = new System.Drawing.Point(164, 324);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(70, 70);
            this.number3.TabIndex = 10;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = false;
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.Color.Transparent;
            this.number4.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number4.ButtonType = null;
            this.number4.FlatAppearance.BorderSize = 0;
            this.number4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4.Location = new System.Drawing.Point(12, 248);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(70, 70);
            this.number4.TabIndex = 9;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = false;
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.Color.Transparent;
            this.number5.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number5.ButtonType = null;
            this.number5.FlatAppearance.BorderSize = 0;
            this.number5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5.Location = new System.Drawing.Point(88, 248);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(70, 70);
            this.number5.TabIndex = 8;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = false;
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.Color.Transparent;
            this.number6.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number6.ButtonType = null;
            this.number6.FlatAppearance.BorderSize = 0;
            this.number6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number6.Location = new System.Drawing.Point(164, 248);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(70, 70);
            this.number6.TabIndex = 7;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = false;
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.Color.Transparent;
            this.number7.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number7.ButtonType = null;
            this.number7.FlatAppearance.BorderSize = 0;
            this.number7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number7.Location = new System.Drawing.Point(12, 172);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(70, 70);
            this.number7.TabIndex = 6;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = false;
            // 
            // number8
            // 
            this.number8.BackColor = System.Drawing.Color.Transparent;
            this.number8.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number8.ButtonType = null;
            this.number8.FlatAppearance.BorderSize = 0;
            this.number8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number8.Location = new System.Drawing.Point(88, 172);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(70, 70);
            this.number8.TabIndex = 5;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = false;
            // 
            // number9
            // 
            this.number9.BackColor = System.Drawing.Color.Transparent;
            this.number9.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.number9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number9.ButtonType = null;
            this.number9.FlatAppearance.BorderSize = 0;
            this.number9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number9.Location = new System.Drawing.Point(164, 172);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(70, 70);
            this.number9.TabIndex = 4;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = false;
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(12, 35);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(322, 80);
            this.inputBox.TabIndex = 23;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.BackColor = System.Drawing.Color.Transparent;
            this.clearEntryButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.clearEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearEntryButton.ButtonType = null;
            this.clearEntryButton.FlatAppearance.BorderSize = 0;
            this.clearEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryButton.Location = new System.Drawing.Point(12, 131);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(156, 35);
            this.clearEntryButton.TabIndex = 25;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.ButtonType = null;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(178, 131);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(156, 35);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // operationDisplay
            // 
            this.operationDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.operationDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operationDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationDisplay.Location = new System.Drawing.Point(12, 4);
            this.operationDisplay.Multiline = true;
            this.operationDisplay.Name = "operationDisplay";
            this.operationDisplay.Size = new System.Drawing.Size(322, 31);
            this.operationDisplay.TabIndex = 27;
            this.operationDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 481);
            this.Controls.Add(this.operationDisplay);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.timesButton);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number9);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CalculatorButton number9;
        private CalculatorButton number8;
        private CalculatorButton number7;
        private CalculatorButton number4;
        private CalculatorButton number5;
        private CalculatorButton number6;
        private CalculatorButton number1;
        private CalculatorButton number2;
        private CalculatorButton number3;
        private CalculatorButton divideButton;
        private CalculatorButton timesButton;
        private CalculatorButton minusButton;
        private CalculatorButton plusButton;
        private CalculatorButton answerButton;
        private CalculatorButton number0;
        private CalculatorButton decimalButton;
        private CalculatorButton signButton;
        private CalculatorButton deleteButton;
        private System.Windows.Forms.TextBox inputBox;
        private CalculatorButton clearEntryButton;
        private CalculatorButton clearButton;
        private System.Windows.Forms.TextBox operationDisplay;
    }
}

