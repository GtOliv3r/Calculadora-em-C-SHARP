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
    public partial class Form1 : Form
    {

        decimal value1 = 0,value2 = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }


        //EVENTOS CLICK dos Botões

        private void button20_Click(object sender, EventArgs e)
        {
            txtResults.Text += "0"; // Declaração do botão
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResults.Text += "1"; // Declaração do botão
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResults.Text += "2"; // Declaração do botão
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResults.Text += "3"; // Declaração do botão
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResults.Text += "4"; // Declaração do botão
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResults.Text += "5"; // Declaração do botão
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResults.Text += "6"; // Declaração do botão
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResults.Text += "7"; // Declaração do botão
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResults.Text += "8"; // Declaração do botão
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResults.Text += "9"; // Declaração do botão
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResults.Text += "."; // Declaração do botão
        }

        private void button11_Click(object sender, EventArgs e)
        {
            value2 = decimal.Parse(txtResults.Text, CultureInfo.InvariantCulture); //coletando o número digitado na caixa de texto e armazenando em value1, com carring de String para decimal
            if(operation == "SOMA")
            {
                txtResults.Text = Convert.ToString(value1 + value2); //Converte o resultado decimal em String e atribui essa String no Campo de Texto
            }

            else if (operation == "SUBTRAÇÃO")
            {
                txtResults.Text = Convert.ToString(value1 - value2); //Converte o resultado decimal em String e atribui essa String no Campo de Texto
            }

            else if (operation == "MULTIPLICAÇÃO")
            {
                txtResults.Text = Convert.ToString(value1 * value2); //Converte o resultado decimal em String e atribui essa String no Campo de Texto
            }

            else
            {
                txtResults.Text = Convert.ToString(value1 / value2); //Converte o resultado decimal em String e atribui essa String no Campo de Texto
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(txtResults.Text != "")
            {
                value1 = decimal.Parse(txtResults.Text, CultureInfo.InvariantCulture); //coletando o número digitado na caixa de texto e armazenando em value1, com carring de String para decimal
                txtResults.Text = ""; // Limpando o campo de texto
                operation = "SUBTRAÇÃO"; // Armazenando a String chamada "SUBTRAÇÃO" na variavel operation
                lblOperation.Text = "-"; // Atribuindo ao texto da label lblOperation a String "-"
            }

            else
            {
                MessageBox.Show("Digite algum valor antes para poder realizar a subtração"); //Mostra pop up de mensagem para informar
            }
        }
            

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResults.Text != "")
            {
                value1 = decimal.Parse(txtResults.Text, CultureInfo.InvariantCulture); //coletando o número digitado na caixa de texto e armazenando em value1, com carring de String para decimal
                txtResults.Text = ""; // Limpando o campo de texto
                operation = "MULTIPLICAÇÃO"; // Armazenando a String chamada "MULTIPLICAÇÃO" na variavel operation
                lblOperation.Text = "x"; // Atribuindo ao texto da label lblOperation a String "x"
            }

            else
            {
                MessageBox.Show("Digite algum valor antes para poder realizar a multiplicação"); //Mostra pop up de mensagem para informar
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResults.Text != "")
            {
                value1 = decimal.Parse(txtResults.Text, CultureInfo.InvariantCulture); //coletando o número digitado na caixa de texto e armazenando em value1, com carring de String para decimal
                txtResults.Text = ""; // Limpando o campo de texto
                operation = "DIVISÃO"; // Armazenando a String chamada "DIVISÃO" na variavel operation
                lblOperation.Text = "/"; // Atribuindo ao texto da label lblOperation a String "/"
            }

            else
            {
                MessageBox.Show("Digite algum valor antes para poder realizar a divisão"); //Mostra pop up de mensagem para informar
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";  //Limpando o campo de texto
            lblOperation.Text = ""; //Limpando o campo de texto da label
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResults.Text = ""; //Limpando o campo de texto
            value1 = 0; //setando o valor para 0 de value2
            value2 = 0; //setando o valor para 0 de value2
            lblOperation.Text = ""; //Limpando o campo de texto da label
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResults.Text != "")
            {
                value1 = decimal.Parse(txtResults.Text, CultureInfo.InvariantCulture); //coletando o número digitado na caixa de texto e armazenando em value1, com carring de String para decimal
                txtResults.Text = ""; // Limpando o campo de texto
                operation = "SOMA"; // Armazenando a String chamada "SOMA" na variavel operation
                lblOperation.Text = "+"; // Atribuindo ao texto da label lblOperation a String "+"
            }

            else
            {
                MessageBox.Show("Digite algum valor antes para poder realizar a soma"); //Mostra pop up de mensagem para informar
            }
            
        }
    }
}
