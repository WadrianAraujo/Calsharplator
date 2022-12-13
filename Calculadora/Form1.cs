using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "9";
        }
    }
}
