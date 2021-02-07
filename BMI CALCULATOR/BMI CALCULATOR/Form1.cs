using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_CALCULATOR
{
    public partial class Form1 : Form
    {
        double height;
        double weight;
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TxtBMI.BackColor = Color.White;
            height = Double.Parse(textBox2.Text);
            weight = Double.Parse(textBox1.Text);

            total = weight / (height * height);
            TxtBMI.Text = String.Format("{0:f}", total);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            TxtBMI.Text = "";
            TxtBMI.BackColor = Color.White;
        }
    }
}
