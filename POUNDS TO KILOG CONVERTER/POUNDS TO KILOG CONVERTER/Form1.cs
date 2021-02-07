using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POUNDS_TO_KILOG_CONVERTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double kg = Double.Parse(textBox1.Text); ;
            double result = kg * 2.204;
            textBox3.Text = result.ToString() + " lb";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double lb = Double.Parse(textBox2.Text); ;
            double result = lb * 0.454;
            textBox3.Text = result.ToString() + " kg";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
