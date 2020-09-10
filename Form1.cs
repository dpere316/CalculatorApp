using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        Boolean operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
            {
                result.Clear();
            }
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button_Click_Clear(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void button_Click_ClearEntry(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
        }

        private void button_Click_Equal(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;

        }
    }
}
