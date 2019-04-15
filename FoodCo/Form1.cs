using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Estudante: Douglas Gorges RA:336650713886

//O prazo de entrega desse projeto foi estendido por eu ter participado da reunião com o MEC

namespace FoodCo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) // Esse método foi criado a partir de um clique-duplo errado. Mas se eu excluo dá erro no Visual Studio
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Básico")
            {
                label9.Text = "R$180,00";
            }
        }

        private void Form1_Load(object sender, EventArgs e) // Esse método foi criado a partir de um clique-duplo errado. Mas se eu excluo dá erro no Visual Studio
        {

        }

        private void combo(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Básico")
            {


                label9.Text = "R$130.00";
            }

            if (comboBox3.Text == "Intermediário"){


                label9.Text = "R$180.00";
            }

            if (comboBox3.Text == "Avançado"){
                label9.Text = "R$300.00";
            }
        }

        private void label10_Click(object sender, EventArgs e)// Esse método foi criado a partir de um clique-duplo errado. Mas se eu excluo dá erro no Visual Studio
        {

        }

        private void status(object sender, EventArgs e) // Eu gostaria que o mesmo botão do formulário chamasse dois métodos diferentes, assim eu poderia separar a mensagem de confirmação num método exclusivo.
        {
            label10.Text = "Cadastrado com sucesso!"; //Busquei alguma forma de fazer essa mensagem ser exibida em uma nova janela de formulário. Mas a função Form2.Show() não funcionou.
            label9.Text = "R$ --";                    //Tambem tentei fazer com que a mensagem "Cadastrado com sucesso!" aparecesse apenas por alguns segundos, mas não vi forma de fazê-lo.
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void clear(object sender, EventArgs e)
        {
            label9.Text = "R$ --";
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }
    }
}
