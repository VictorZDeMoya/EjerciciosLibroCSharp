using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int n, i, fac = 1;

            n = Convert.ToInt32(textBox1.Text); 
            for(i=1; i <= n; i++)
            {
                fac = fac * i;
                label2.Text = "El factorial del numero es: " + fac.ToString();
            }
        }
    }
}
