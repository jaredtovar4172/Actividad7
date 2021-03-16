using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej7_EcuacionesLineales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones p = new Operaciones();
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double ei = double.Parse(textBox4.Text);
            double d = double.Parse(textBox5.Text);
            double f = double.Parse(textBox6.Text);
            double x = p.CalculoDeX(a, b, c, ei , d, f);
            this.textBox7.Text = x.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operaciones p = new Operaciones();
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double ei = double.Parse(textBox4.Text);
            double d = double.Parse(textBox5.Text);
            double f = double.Parse(textBox6.Text);
            double y = p.CalculoDeY(a, b, c, ei, d, f);
            this.textBox8.Text = y.ToString();
        }
    }
}
