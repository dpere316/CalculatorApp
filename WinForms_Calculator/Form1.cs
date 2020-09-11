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
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0"))
            {
                result.Clear();
            }
           
           
            Button b = (Button)sender;

            if(b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;

            expression.Text = result.Text;
        }

        private void button_Click_Clear(object sender, EventArgs e)
        {
            result.Text="0";
            expression.Text = "";
        }

        private void button_Click_Equal(object sender, EventArgs e)
        {
            expression.Text = "";
            DataTable dt = new DataTable();
            var v = new Object();
            try
            {
                v = dt.Compute(result.Text, "");
            }
            catch(Exception f)
            {
                v = "NAN";
            }

            result.Text = v.ToString();
            
            
        }

        
    }
}
