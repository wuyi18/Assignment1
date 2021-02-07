using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WORD_DISPLAY_AND_COUNTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            Char[] mychar = { ' ', ',', ';', '?' };
            string[] word = textBox1.Text.Split(mychar);
            listBox1.Items.Clear();
            foreach (string item in word)
            {
                if (item.Length > 0)
                {
                    listBox1.Items.Add(item);
                    i = i + 1;
                }
            }
            textBox2.Text = i.ToString();

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
