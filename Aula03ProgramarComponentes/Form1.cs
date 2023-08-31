using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03ProgramarComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            nome = textBox1.Text;
            MessageBox.Show($"Seja bem-vinde {nome}!");
            lblSeuNome.Text = "Seu nome é" + nome;
            //lblSeuNome.Text = ($"Seu nome é: {textBox1.Text}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //textBox1.Text = "";
            //textBox1.Text = String.Empty;
        }
    }
}
