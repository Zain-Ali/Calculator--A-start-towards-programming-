namespace Calculator
{
    partial class CalculatorUI
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
            this.userInputTestBox = new System.Windows.Forms.TextBox();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.divideOperatorButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.multiplyOperatorButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.minusOperatorButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.plusOperatorButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.basicCalculatorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInputTestBox
            // 
            this.userInputTestBox.Location = new System.Drawing.Point(12, 37);
            this.userInputTestBox.Multiline = true;
            this.userInputTestBox.Name = "userInputTestBox";
            this.userInputTestBox.Size = new System.Drawing.Size(319, 42);
            this.userInputTestBox.TabIndex = 0;
            this.userInputTestBox.TextChanged += new System.EventHandler(this.userInputTestBox_TextChanged);
            this.userInputTestBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userInputTestBox_KeyPress);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(12, 105);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(59, 45);
            this.sevenButton.TabIndex = 1;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(77, 105);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(59, 45);
            this.eightButton.TabIndex = 2;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(142, 105);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(59, 45);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // divideOperatorButton
            // 
            this.divideOperatorButton.Location = new System.Drawing.Point(207, 105);
            this.divideOperatorButton.Name = "divideOperatorButton";
            this.divideOperatorButton.Size = new System.Drawing.Size(59, 45);
            this.divideOperatorButton.TabIndex = 4;
            this.divideOperatorButton.Text = "/";
            this.divideOperatorButton.UseVisualStyleBackColor = true;
            this.divideOperatorButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // CEButton
            // 
            this.CEButton.Location = new System.Drawing.Point(272, 105);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(59, 45);
            this.CEButton.TabIndex = 5;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(271, 160);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(59, 45);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button6_Click);
            // 
            // multiplyOperatorButton
            // 
            this.multiplyOperatorButton.Location = new System.Drawing.Point(206, 160);
            this.multiplyOperatorButton.Name = "multiplyOperatorButton";
            this.multiplyOperatorButton.Size = new System.Drawing.Size(59, 45);
            this.multiplyOperatorButton.TabIndex = 9;
            this.multiplyOperatorButton.Text = "*";
            this.multiplyOperatorButton.UseVisualStyleBackColor = true;
            this.multiplyOperatorButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(141, 160);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(59, 45);
            this.sixButton.TabIndex = 8;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(76, 160);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(59, 45);
            this.fiveButton.TabIndex = 7;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(11, 160);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(59, 45);
            this.fourButton.TabIndex = 6;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // minusOperatorButton
            // 
            this.minusOperatorButton.Location = new System.Drawing.Point(206, 215);
            this.minusOperatorButton.Name = "minusOperatorButton";
            this.minusOperatorButton.Size = new System.Drawing.Size(59, 45);
            this.minusOperatorButton.TabIndex = 14;
            this.minusOperatorButton.Text = "-";
            this.minusOperatorButton.UseVisualStyleBackColor = true;
            this.minusOperatorButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(141, 215);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(59, 45);
            this.threeButton.TabIndex = 13;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(76, 215);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(59, 45);
            this.twoButton.TabIndex = 12;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(11, 215);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(59, 45);
            this.oneButton.TabIndex = 11;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(271, 215);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(59, 101);
            this.equalButton.TabIndex = 20;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // plusOperatorButton
            // 
            this.plusOperatorButton.Location = new System.Drawing.Point(206, 271);
            this.plusOperatorButton.Name = "plusOperatorButton";
            this.plusOperatorButton.Size = new System.Drawing.Size(59, 45);
            this.plusOperatorButton.TabIndex = 19;
            this.plusOperatorButton.Text = "+";
            this.plusOperatorButton.UseVisualStyleBackColor = true;
            this.plusOperatorButton.Click += new System.EventHandler(this.Operator_Click);
            this.plusOperatorButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userInputTestBox_KeyPress);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(141, 271);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(59, 45);
            this.dotButton.TabIndex = 18;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(11, 271);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(125, 45);
            this.zeroButton.TabIndex = 16;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // basicCalculatorButton
            // 
            this.basicCalculatorButton.Location = new System.Drawing.Point(-2, -2);
            this.basicCalculatorButton.Name = "basicCalculatorButton";
            this.basicCalculatorButton.Size = new System.Drawing.Size(107, 23);
            this.basicCalculatorButton.TabIndex = 21;
            this.basicCalculatorButton.Text = "Basic Calculator";
            this.basicCalculatorButton.UseVisualStyleBackColor = true;
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 334);
            this.Controls.Add(this.basicCalculatorButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.plusOperatorButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.minusOperatorButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.multiplyOperatorButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.divideOperatorButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.userInputTestBox);
            this.Name = "CalculatorUI";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputTestBox;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button divideOperatorButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button multiplyOperatorButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button minusOperatorButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button plusOperatorButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button basicCalculatorButton;
    }
}

