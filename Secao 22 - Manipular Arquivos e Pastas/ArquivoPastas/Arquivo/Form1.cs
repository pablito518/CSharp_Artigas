using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string pasta = @"c:\curso\";
            string arquivo = "teste.txt";

            //bool res = File.Exists(pasta + arquivo);

            //lbl1.Text = res.ToString();

            //File.Delete(pasta + arquivo);
            //if (!File.Exists(pasta + arquivo))
            //{
            //    File.Create(pasta + arquivo).Close();
            //    lbl1.Text = "Arquivo criado";
            //}
            //else
            //{
            //    lbl1.Text = "Arquivo já existe";
            //}

            //if (File.Exists(pasta + arquivo))
            //{
            //    File.Copy(pasta + arquivo, pasta + "Copia.txt", true);
            //    lbl1.Text = "Copiado";
            //}
            //else
            //{
            //    lbl1.Text = "Arquivo não existe";
            //}

            //File.Move(pasta + arquivo, pasta + @"destino\" + arquivo);


            //File.WriteAllText(pasta + arquivo, "Teste de escrita de arquivo", Encoding.UTF8);

            //lbl1.Text = File.ReadAllText(pasta + arquivo, Encoding.UTF8);

            lbl1.Text = File.GetCreationTime(pasta + arquivo).ToString();

            File.SetCreationTime(pasta + arquivo, DateTime.Now);

        }
    }
}
