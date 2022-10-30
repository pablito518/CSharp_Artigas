using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            //Size tamanho = new Size();
            //tamanho.Width = 400;
            //tamanho.Height = 200;

            InitializeComponent();
            //this.Text = "Gabriel Artigas";
            //this.Size = tamanho;
            //this.Size = new Size(400, 200);
            //this.ControlBox = false;



        }
        private void Form_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a form";

        }

        private void Form_Click(object sender, EventArgs e)
        {
            this.Text = "Clicando na form";
            //this.Size = new Size(400, 200);
            this.Size = new Size(Width * 2, Height * 2);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja fechar?", "Confirmação", MessageBoxButtons.YesNo);
        }

        private void MeuMetodo(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicou no botão";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Evento MouseEnter acionado";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Evento MouseLeave acionado";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(150, 100);
        }
    }
}
