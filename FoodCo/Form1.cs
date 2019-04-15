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

namespace FoodCo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Básico")
            {
                label9.Text = "R$180,00";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void status(object sender, EventArgs e)
        {
            label10.Text = "Cadastrado com sucesso!";
            label9.Text = "R$ --";
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
