using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        decimal valor1, valor2;
        string operation;
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
            valor2 = decimal.Parse(TxtResult.Text, CultureInfo.InvariantCulture);
            switch(operation)
            {
                case "division":
                    TxtResult.Text = Convert.ToString(valor1 / valor2);
                    break;
                case "multiplication":
                    TxtResult.Text = Convert.ToString(valor1 * valor2);
                    break;
                case "subtraction":
                    TxtResult.Text = Convert.ToString(valor1 - valor2);
                    break;
                case "addition":
                    TxtResult.Text = Convert.ToString(valor1 * valor2);
                    break;
            }
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

        private void button17_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(TxtResult.Text,CultureInfo.InvariantCulture);
            TxtResult.Text = "";
            operation = "addition";
            LblOperation.Text = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(TxtResult.Text, CultureInfo.InvariantCulture);
            TxtResult.Text = "";
            operation = "division";
            LblOperation.Text = "/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(TxtResult.Text, CultureInfo.InvariantCulture);
            TxtResult.Text = "";
            operation = "multiplication";
            LblOperation.Text = "X";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(TxtResult.Text, CultureInfo.InvariantCulture);
            TxtResult.Text = "";
            operation = "subtraction";
            LblOperation.Text = "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtResult.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            TxtResult.Text = "";
            LblOperation.Text = "";
            operation = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TxtResult.Text += ".";
        }
    }
}
