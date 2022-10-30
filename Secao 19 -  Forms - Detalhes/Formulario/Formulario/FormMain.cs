using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSegunda_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FormSegunda f = new FormSegunda();
            //f.Mensagem = "Jonathan";
            //f.Show();
            FormSegunda f = new FormSegunda("Joestar");
            f.ShowDialog();
            if(f.Mensagem != null)
            {
                lblTitulo.Text = f.Mensagem;
            }
            this.Show();
        }

        private void btnSegundaFormThread_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => Application.Run(new FormSegunda()));
            t.Start();    
        }

        private void mFileNovo_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start();
            
        }

        private void mFileAbrir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSegunda f = new FormSegunda();
            f.ShowDialog();
            Show();
        }

        private void mFileSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mHelpSobreDes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pablito");
        }

        private void mHelpSobreVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0");
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMenu.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                menuHelpSobre.Text = "Help";
                btnSegunda.Text = "Second Form";
                btnSegundaFormThread.Text = "Second Form - Thread";
                lblTitulo.Text = "Main";
            }
            else
            {
                menuFile.Text = "Arquivo";
                menuHelp.Text = "Ajuda";
                btnSegunda.Text = "Primeira Form";
                btnSegundaFormThread.Text = "Segunda Form Thread";
                lblTitulo.Text = "Principal";
            }
        }

        private void mPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Keys.Return
            {
                lblTitulo.Text = mPesquisar.Text;
                mPesquisar.Text = "";
            }
        }
    }
}
