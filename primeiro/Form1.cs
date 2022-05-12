using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiro
{
    public partial class Calculos : Form
    {
        public Calculos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double rst;

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            rst = n1 + n2;
            txtResultado.Text = rst.ToString(); 
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double rst;

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            rst = n1 * n2;
            txtResultado.Text = rst.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "9";
        }
    }
}
