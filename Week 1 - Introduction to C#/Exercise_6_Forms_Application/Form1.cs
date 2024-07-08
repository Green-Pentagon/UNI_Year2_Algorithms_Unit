using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_6_Forms_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OutputTextBox.Text = (Convert.ToDouble(Input1TextBox.Text) + Convert.ToDouble(Input2TextBox.Text)).ToString();
        }

        private void subtractRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OutputTextBox.Text = (Convert.ToDouble(Input1TextBox.Text) - Convert.ToDouble(Input2TextBox.Text)).ToString();
        }

        private void multiplyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OutputTextBox.Text = (Convert.ToDouble(Input1TextBox.Text) * Convert.ToDouble(Input2TextBox.Text)).ToString();
        }

        private void divideRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Input2TextBox.Text) != 0)
                //seems to be broken for some values, not a rounding error but something of an incorrect filetype error? happens probably due to some sort of overflow.
            {
                OutputTextBox.Text = Math.Round((Convert.ToDouble(Input1TextBox.Text) / Convert.ToDouble(Input2TextBox.Text)),3).ToString();
            }
        }
    }
}
