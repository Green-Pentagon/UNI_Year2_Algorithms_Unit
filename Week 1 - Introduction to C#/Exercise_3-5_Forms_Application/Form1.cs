using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_2_Exercise
{
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)//could probably make this more efficient with a temp variable?
            {
                OutputTextBox.ForeColor = Color.Red;
                OutputTextBox.Text = InputTextBox.Text;
                
            }
            else
            {
                OutputTextBox.Clear();
                OutputTextBox.ForeColor = Color.Black;
            }
        }

        private void Exercise2_Load(object sender, EventArgs e)
        {
            NoteLabel.Text = "";
        }

        private void NoteLabel_Click(object sender, EventArgs e)
        {

        }
        //exercise 4
        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)//could probably make this more efficient with a temp variable?
        //    {
        //        InputTextBox.ForeColor = Color.Red;
        //    }
        //    else
        //    {
        //        InputTextBox.ForeColor = Color.Black;
        //    }
        //}
    }
}
