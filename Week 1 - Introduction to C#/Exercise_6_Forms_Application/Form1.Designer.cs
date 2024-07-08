namespace Exercise_6_Forms_Application
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
            this.Input1TextBox = new System.Windows.Forms.TextBox();
            this.Input2TextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.Operators = new System.Windows.Forms.GroupBox();
            this.divideRadioButton = new System.Windows.Forms.RadioButton();
            this.multiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.subtractRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.Input1Label = new System.Windows.Forms.Label();
            this.Input2Label = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Operators.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input1TextBox
            // 
            this.Input1TextBox.Location = new System.Drawing.Point(182, 45);
            this.Input1TextBox.Name = "Input1TextBox";
            this.Input1TextBox.Size = new System.Drawing.Size(100, 26);
            this.Input1TextBox.TabIndex = 0;
            // 
            // Input2TextBox
            // 
            this.Input2TextBox.Location = new System.Drawing.Point(182, 77);
            this.Input2TextBox.Name = "Input2TextBox";
            this.Input2TextBox.Size = new System.Drawing.Size(100, 26);
            this.Input2TextBox.TabIndex = 1;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(182, 133);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(100, 26);
            this.OutputTextBox.TabIndex = 2;
            // 
            // Operators
            // 
            this.Operators.Controls.Add(this.divideRadioButton);
            this.Operators.Controls.Add(this.multiplyRadioButton);
            this.Operators.Controls.Add(this.subtractRadioButton);
            this.Operators.Controls.Add(this.addRadioButton);
            this.Operators.Location = new System.Drawing.Point(377, 24);
            this.Operators.Name = "Operators";
            this.Operators.Size = new System.Drawing.Size(101, 162);
            this.Operators.TabIndex = 3;
            this.Operators.TabStop = false;
            this.Operators.Text = "Operators";
            // 
            // divideRadioButton
            // 
            this.divideRadioButton.AutoSize = true;
            this.divideRadioButton.Location = new System.Drawing.Point(7, 119);
            this.divideRadioButton.Name = "divideRadioButton";
            this.divideRadioButton.Size = new System.Drawing.Size(38, 24);
            this.divideRadioButton.TabIndex = 3;
            this.divideRadioButton.TabStop = true;
            this.divideRadioButton.Text = "/";
            this.divideRadioButton.UseVisualStyleBackColor = true;
            this.divideRadioButton.CheckedChanged += new System.EventHandler(this.divideRadioButton_CheckedChanged);
            // 
            // multiplyRadioButton
            // 
            this.multiplyRadioButton.AutoSize = true;
            this.multiplyRadioButton.Location = new System.Drawing.Point(7, 88);
            this.multiplyRadioButton.Name = "multiplyRadioButton";
            this.multiplyRadioButton.Size = new System.Drawing.Size(41, 24);
            this.multiplyRadioButton.TabIndex = 2;
            this.multiplyRadioButton.TabStop = true;
            this.multiplyRadioButton.Text = "x";
            this.multiplyRadioButton.UseVisualStyleBackColor = true;
            this.multiplyRadioButton.CheckedChanged += new System.EventHandler(this.multiplyRadioButton_CheckedChanged);
            // 
            // subtractRadioButton
            // 
            this.subtractRadioButton.AutoSize = true;
            this.subtractRadioButton.Location = new System.Drawing.Point(7, 57);
            this.subtractRadioButton.Name = "subtractRadioButton";
            this.subtractRadioButton.Size = new System.Drawing.Size(39, 24);
            this.subtractRadioButton.TabIndex = 1;
            this.subtractRadioButton.TabStop = true;
            this.subtractRadioButton.Text = "-";
            this.subtractRadioButton.UseVisualStyleBackColor = true;
            this.subtractRadioButton.CheckedChanged += new System.EventHandler(this.subtractRadioButton_CheckedChanged);
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Location = new System.Drawing.Point(7, 26);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(43, 24);
            this.addRadioButton.TabIndex = 0;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "+";
            this.addRadioButton.UseVisualStyleBackColor = true;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.addRadioButton_CheckedChanged);
            // 
            // Input1Label
            // 
            this.Input1Label.AutoSize = true;
            this.Input1Label.Location = new System.Drawing.Point(56, 51);
            this.Input1Label.Name = "Input1Label";
            this.Input1Label.Size = new System.Drawing.Size(100, 20);
            this.Input1Label.TabIndex = 4;
            this.Input1Label.Text = "First Number";
            // 
            // Input2Label
            // 
            this.Input2Label.AutoSize = true;
            this.Input2Label.Location = new System.Drawing.Point(43, 77);
            this.Input2Label.Name = "Input2Label";
            this.Input2Label.Size = new System.Drawing.Size(124, 20);
            this.Input2Label.TabIndex = 5;
            this.Input2Label.Text = "Second Number";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(76, 139);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(58, 20);
            this.OutputLabel.TabIndex = 6;
            this.OutputLabel.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 242);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Input2Label);
            this.Controls.Add(this.Input1Label);
            this.Controls.Add(this.Operators);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.Input2TextBox);
            this.Controls.Add(this.Input1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Operators.ResumeLayout(false);
            this.Operators.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1TextBox;
        private System.Windows.Forms.TextBox Input2TextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.GroupBox Operators;
        private System.Windows.Forms.RadioButton divideRadioButton;
        private System.Windows.Forms.RadioButton multiplyRadioButton;
        private System.Windows.Forms.RadioButton subtractRadioButton;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.Label Input1Label;
        private System.Windows.Forms.Label Input2Label;
        private System.Windows.Forms.Label OutputLabel;
    }
}

