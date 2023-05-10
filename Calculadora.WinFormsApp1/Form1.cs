using System.Globalization;

namespace Calculadora.WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text += ".";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (TxtOperacoes.Text != "")
            {
                valor1 = decimal.Parse(TxtOperacoes.Text, CultureInfo.InvariantCulture);
                TxtOperacoes.Text = "";
                operacao = "SOMA";
                labelOperacoes.Text = "+";

            }

            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação!");
            }

        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (TxtOperacoes.Text != "")
            {
                valor1 = decimal.Parse(TxtOperacoes.Text, CultureInfo.InvariantCulture);
                TxtOperacoes.Text = "";
                operacao = "SUB";
                labelOperacoes.Text = "-";

            }

            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação!");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (TxtOperacoes.Text != "")
            {
                valor1 = decimal.Parse(TxtOperacoes.Text, CultureInfo.InvariantCulture);
                TxtOperacoes.Text = "";
                operacao = "MULTIPLICACAO";
                labelOperacoes.Text = "x";

            }

            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação!");
            }


        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (TxtOperacoes.Text != "")
            {
                valor1 = decimal.Parse(TxtOperacoes.Text, CultureInfo.InvariantCulture);
                TxtOperacoes.Text = "";
                operacao = "DIVISAO";
                labelOperacoes.Text = "/";

            }

            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação!");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(TxtOperacoes.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                TxtOperacoes.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                TxtOperacoes.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                TxtOperacoes.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISAO")
            {
                TxtOperacoes.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text = "";
            labelOperacoes.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtOperacoes.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacoes.Text = "";
        }
    }

}