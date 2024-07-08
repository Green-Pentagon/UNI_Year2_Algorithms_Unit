using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_7_Forms_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] expression = InputTextBox.Text.Split(' ');
                double result = 0;
                switch (expression[1]) {
                    case "+":
                        result = Convert.ToDouble(expression[0]) + Convert.ToDouble(expression[2]);
                        break;
                    case "-":
                        result = Convert.ToDouble(expression[0]) - Convert.ToDouble(expression[2]);
                        break;
                    case "*":
                        result = Convert.ToDouble(expression[0]) * Convert.ToDouble(expression[2]);
                        break;
                    case "/":
                        if (Convert.ToInt32(expression[2]) != 0)
                        result = Convert.ToDouble(expression[0]) / Convert.ToDouble(expression[2]);
                        break;
                    case "%":
                        result = Convert.ToDouble(expression[0]) % Convert.ToDouble(expression[2]);
                        break;
                    
                }
                OutputTextBox.Text = Math.Round(result,3).ToString();
            }
            catch (Exception ex)
            {
                OutputTextBox.Text = "INVALID INPUT DETECTED";
            }
            
        }
    }
}
