using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double weight;
        public double height;
        public double msquare;
        public double BMI;

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {            
            bool IsDouble = double.TryParse(heightTextBox.Text, out height);
        }
        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            bool IsDouble = double.TryParse(weightTextBox.Text, out weight);
        }

         
        
        private void inRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            height = (((double.Parse(heightTextBox.Text)) * 2.54)/100);
        }

        private void poundsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            weight = (double.Parse(weightTextBox.Text)) / 2.2;
        }

        private void cmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            height = (double.Parse(heightTextBox.Text)/100);
        }

        private void kgRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            weight = double.Parse(weightTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                msquare = (height * height);
                BMI = weight / msquare;

                //Apply description of calculated BMI to BMI Description Label: 
                if (BMI < 18.5)
                {
                    bmiDescriptionLabel.Text = "Underweight";
                    bmiDescriptionLabel.ForeColor = System.Drawing.Color.Tomato;
                }
                if (BMI > 18.5 && BMI < 24.9)
                {
                    bmiDescriptionLabel.Text = "Healthy";
                    bmiDescriptionLabel.ForeColor = System.Drawing.Color.SeaGreen;
                }
                if (BMI > 24.9 && BMI < 30)
                {
                    bmiDescriptionLabel.Text = "Overweight";
                    bmiDescriptionLabel.ForeColor = System.Drawing.Color.Orange;
                }
                if (BMI > 30)
                {
                    bmiDescriptionLabel.Text = "Obese";
                    bmiDescriptionLabel.ForeColor = System.Drawing.Color.Red;
                }

                //Convert BMI result to string and print in designated label:
                BMIlabel.Text = BMI.ToString("N");
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            heightTextBox.Clear();
            weightTextBox.Clear();
        }
              
      }
}

