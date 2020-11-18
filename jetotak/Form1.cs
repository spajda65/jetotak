using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jetotak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1);
            int b = Convert.ToInt32(textBox2);

            label1.Text = (a + b).ToString();
            label2.Text = (a - b).ToString();
            label3.Text = (a * b).ToString();

            if (b != 0) label4.Text = (a / b).ToString();
            else label4.Text = " nelze ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
