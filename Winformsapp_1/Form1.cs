using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformsapp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = TBname.Text;
            // MessageBox.Show("Hello World" + Text + "Welcome to Jamaica");
            label2.Text = $"Hello {name}. You are welcome here!";
         }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
