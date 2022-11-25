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
    public partial class name0 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public name0()
        {
            InitializeComponent();
        }



        private void button20_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = txtResultado.Text + "0";
            txtResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";

            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma.");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUBTRACAO";
            lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração.");
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULTIPLICACAO";
            lblOperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação.");
            }

        }


        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIVISAO";
            lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {

                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if(operacao == "SOMA")
                {
                   txtResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if(operacao == "SUBTRACAO")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULTIPLICACAO")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }

            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar o cálculo.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }
    }
}
