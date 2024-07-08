using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2_Stakcs___Queues
{
    public partial class Form1 : Form
    {
        private JobStack jobs;
        public Form1()
        {
            jobs = new JobStack(); //create empty Stack
            InitializeComponent();
        }
    }
}
