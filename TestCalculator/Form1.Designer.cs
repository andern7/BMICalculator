namespace TestCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmRadioButton = new System.Windows.Forms.RadioButton();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.kgRadioButton = new System.Windows.Forms.RadioButton();
            this.poundsRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.BMIlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bmiDescriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.inRadioButton = new System.Windows.Forms.RadioButton();
            this.heightGroupBox = new System.Windows.Forms.GroupBox();
            this.weightGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.heightGroupBox.SuspendLayout();
            this.weightGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate BMI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Weight: ";
            // 
            // cmRadioButton
            // 
            this.cmRadioButton.AutoSize = true;
            this.cmRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmRadioButton.Location = new System.Drawing.Point(292, 19);
            this.cmRadioButton.Name = "cmRadioButton";
            this.cmRadioButton.Size = new System.Drawing.Size(96, 24);
            this.cmRadioButton.TabIndex = 5;
            this.cmRadioButton.TabStop = true;
            this.cmRadioButton.Text = "centimeters";
            this.cmRadioButton.UseVisualStyleBackColor = true;
            this.cmRadioButton.CheckedChanged += new System.EventHandler(this.cmRadioButton_CheckedChanged);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(112, 13);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 26);
            this.weightTextBox.TabIndex = 6;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            // 
            // kgRadioButton
            // 
            this.kgRadioButton.AutoSize = true;
            this.kgRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgRadioButton.Location = new System.Drawing.Point(292, 15);
            this.kgRadioButton.Name = "kgRadioButton";
            this.kgRadioButton.Size = new System.Drawing.Size(85, 24);
            this.kgRadioButton.TabIndex = 7;
            this.kgRadioButton.TabStop = true;
            this.kgRadioButton.Text = "kilograms";
            this.kgRadioButton.UseVisualStyleBackColor = true;
            this.kgRadioButton.CheckedChanged += new System.EventHandler(this.kgRadioButton_CheckedChanged);
            // 
            // poundsRadioButton
            // 
            this.poundsRadioButton.AutoSize = true;
            this.poundsRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundsRadioButton.Location = new System.Drawing.Point(218, 15);
            this.poundsRadioButton.Name = "poundsRadioButton";
            this.poundsRadioButton.Size = new System.Drawing.Size(72, 24);
            this.poundsRadioButton.TabIndex = 8;
            this.poundsRadioButton.TabStop = true;
            this.poundsRadioButton.Text = "pounds";
            this.poundsRadioButton.UseVisualStyleBackColor = true;
            this.poundsRadioButton.CheckedChanged += new System.EventHandler(this.poundsRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your BMI is: ";
            // 
            // BMIlabel
            // 
            this.BMIlabel.AutoSize = true;
            this.BMIlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIlabel.Location = new System.Drawing.Point(118, 188);
            this.BMIlabel.Name = "BMIlabel";
            this.BMIlabel.Size = new System.Drawing.Size(0, 19);
            this.BMIlabel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "You are:  ";
            // 
            // bmiDescriptionLabel
            // 
            this.bmiDescriptionLabel.AutoSize = true;
            this.bmiDescriptionLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiDescriptionLabel.Location = new System.Drawing.Point(86, 230);
            this.bmiDescriptionLabel.Name = "bmiDescriptionLabel";
            this.bmiDescriptionLabel.Size = new System.Drawing.Size(0, 19);
            this.bmiDescriptionLabel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Height: ";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightTextBox.Location = new System.Drawing.Point(114, 12);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 26);
            this.heightTextBox.TabIndex = 3;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            // 
            // inRadioButton
            // 
            this.inRadioButton.AutoSize = true;
            this.inRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inRadioButton.Location = new System.Drawing.Point(220, 21);
            this.inRadioButton.Name = "inRadioButton";
            this.inRadioButton.Size = new System.Drawing.Size(66, 24);
            this.inRadioButton.TabIndex = 4;
            this.inRadioButton.TabStop = true;
            this.inRadioButton.Text = "inches";
            this.inRadioButton.UseVisualStyleBackColor = true;
            this.inRadioButton.CheckedChanged += new System.EventHandler(this.inRadioButton_CheckedChanged);
            // 
            // heightGroupBox
            // 
            this.heightGroupBox.Controls.Add(this.inRadioButton);
            this.heightGroupBox.Controls.Add(this.heightTextBox);
            this.heightGroupBox.Controls.Add(this.label1);
            this.heightGroupBox.Controls.Add(this.cmRadioButton);
            this.heightGroupBox.Location = new System.Drawing.Point(8, 15);
            this.heightGroupBox.Name = "heightGroupBox";
            this.heightGroupBox.Size = new System.Drawing.Size(416, 51);
            this.heightGroupBox.TabIndex = 13;
            this.heightGroupBox.TabStop = false;
            // 
            // weightGroupBox
            // 
            this.weightGroupBox.Controls.Add(this.poundsRadioButton);
            this.weightGroupBox.Controls.Add(this.kgRadioButton);
            this.weightGroupBox.Controls.Add(this.weightTextBox);
            this.weightGroupBox.Controls.Add(this.label2);
            this.weightGroupBox.Location = new System.Drawing.Point(8, 70);
            this.weightGroupBox.Name = "weightGroupBox";
            this.weightGroupBox.Size = new System.Drawing.Size(416, 52);
            this.weightGroupBox.TabIndex = 14;
            this.weightGroupBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(259, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.weightGroupBox);
            this.Controls.Add(this.heightGroupBox);
            this.Controls.Add(this.bmiDescriptionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BMIlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Simple BMI Calculator";
            this.heightGroupBox.ResumeLayout(false);
            this.heightGroupBox.PerformLayout();
            this.weightGroupBox.ResumeLayout(false);
            this.weightGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton cmRadioButton;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.RadioButton kgRadioButton;
        private System.Windows.Forms.RadioButton poundsRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BMIlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bmiDescriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.RadioButton inRadioButton;
        private System.Windows.Forms.GroupBox heightGroupBox;
        private System.Windows.Forms.GroupBox weightGroupBox;
        private System.Windows.Forms.Button button2;

    }
}

