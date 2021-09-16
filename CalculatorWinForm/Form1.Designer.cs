
namespace CalculatorWinForm
{
    partial class Form1
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
            this.firstNumber = new System.Windows.Forms.Label();
            this.secondNumber = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultOutput = new System.Windows.Forms.Label();
            this.firstInput = new System.Windows.Forms.TextBox();
            this.secondInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.optionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumber
            // 
            this.firstNumber.AutoSize = true;
            this.firstNumber.Location = new System.Drawing.Point(247, 38);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(93, 17);
            this.firstNumber.TabIndex = 0;
            this.firstNumber.Text = "First Number:";
            // 
            // secondNumber
            // 
            this.secondNumber.AutoSize = true;
            this.secondNumber.Location = new System.Drawing.Point(247, 82);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(114, 17);
            this.secondNumber.TabIndex = 1;
            this.secondNumber.Text = "Second Number:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(247, 215);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(52, 17);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result:";
            // 
            // resultOutput
            // 
            this.resultOutput.AutoSize = true;
            this.resultOutput.Location = new System.Drawing.Point(384, 215);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.Size = new System.Drawing.Size(0, 17);
            this.resultOutput.TabIndex = 3;
            // 
            // firstInput
            // 
            this.firstInput.Location = new System.Drawing.Point(387, 38);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(100, 22);
            this.firstInput.TabIndex = 4;
            // 
            // secondInput
            // 
            this.secondInput.Location = new System.Drawing.Point(387, 77);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(100, 22);
            this.secondInput.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(250, 163);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(331, 163);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 7;
            this.subButton.Text = "Sub";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // multButton
            // 
            this.multButton.Location = new System.Drawing.Point(412, 163);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(75, 23);
            this.multButton.TabIndex = 8;
            this.multButton.Text = "Mult";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.multButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(493, 163);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(75, 23);
            this.divButton.TabIndex = 9;
            this.divButton.Text = "Div";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Location = new System.Drawing.Point(247, 130);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(153, 21);
            this.optionLabel.TabIndex = 10;
            this.optionLabel.Text = "Choose Arithmetic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 293);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.firstInput);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.firstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumber;
        private System.Windows.Forms.Label secondNumber;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultOutput;
        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.TextBox secondInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Label optionLabel;
    }
}

