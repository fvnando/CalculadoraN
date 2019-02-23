using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraN
{
    public partial class Form1 : Form
    {
        string operador;
        double x = 0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnnumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            x = 0;
            validar = false;
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            if(validar==true)
            {
                //MessageBox.Show("Estou na soma");
                x = x + Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(x) + "+";
                txtValor.Text = "";
                operador = "+";
            }
            else
            {
                //MessageBox.Show("Estou na soma2");

                label1.Text = txtValor.Text + btnsoma.Text;
                x = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                x = x * Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(x) + "*";
                txtValor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = txtValor.Text + btnmultiplicacao.Text;
                x = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                x = x - Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(x) + "-";
                txtValor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = txtValor.Text + btnsub.Text;
                x = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                x = x / Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(x) + "/";
                txtValor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = txtValor.Text + btndivisao.Text;
                x = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if(operador == "+")
            {
                //MessageBox.Show("Passei aqui");
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(x + Convert.ToDouble(txtValor.Text));
            }
           else if (operador == "-")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(x - Convert.ToDouble(txtValor.Text));
            }
           else if (operador == "*")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(x * Convert.ToDouble(txtValor.Text));
            }
           else if (operador == "/")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(x / Convert.ToDouble(txtValor.Text));
            }
        }
    }
}
