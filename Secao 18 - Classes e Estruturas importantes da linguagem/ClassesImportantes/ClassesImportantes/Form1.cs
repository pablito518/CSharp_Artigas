using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Boa noite bruno");
            //MessageBox.Show("Vou deixar o oco", "A gente come já");
            //DialogResult res = MessageBox.Show("Porra jamelão", "Tu me fudeu cara", MessageBoxButtons.YesNoCancel);

            //if (res == DialogResult.No)
            //{
            //    lblResultado.Text = "Clicou em Não";            
            //}
            //else if(res == DialogResult.Yes)
            //{
            //    lblResultado.Text = "Clicou em Sim";
            //}
            //else
            //{
            //    lblResultado.Text = "Clicou em Cancelar";
            //}

            MessageBox.Show("Shiren da", "Kore wa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            Random random = new Random(DateTime.Now.Millisecond);
            //  int valor = random.Next();
            //int valor = random.Next(100);

            double valor2 = random.NextDouble() * 5;
            lblResultado.Text = $"Número: {valor2}";

            random.Next(0, 50);
            
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            lblResultado.Text = TimeSpan.FromDays(90.5).ToString();
            //lblResultado.Text = TimeSpan.FromMinutes(90.5).ToString();
            //lblResultado.Text = TimeSpan.FromMinutes(60).ToString();
            //lblResultado.Text = TimeSpan.TicksPerMinute.ToString();
            //TimeSpan time = new TimeSpan(5, 30, 30);

            TimeSpan inicio = new TimeSpan(1, 0, 0);

            TimeSpan fim = new TimeSpan(0, 0, 0);

            //TimeSpan intervalo = fim - inicio;

            TimeSpan intervalo = fim.Subtract(inicio);

            //inicio.Add(fim);

            lblResultado.Text = intervalo.TotalHours.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = DateTime.Now.ToString();
            //lblResultado.Text = DateTime.Now.ToString();
            //lblResultado.Text = DateTime.DaysInMonth(2018,07).ToString();
            //lblResultado.Text = DateTime.IsLeapYear(2022).ToString();
            //lblResultado.Text = DateTime.Now.ToLongDateString();
            //lblResultado.Text = DateTime.Now.ToShortDateString();
            //lblResultado.Text = DateTime.Now.ToLongTimeString();
            //lblResultado.Text = DateTime.Now.ToShortTimeString();
            //lblResultado.Text = DateTime.Now.ToUniversalTime().ToString();
            //lblResultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime date = new DateTime(1985, 01, 10, 14, 35, 30);

            //lblResultado.Text = date.AddDays(2).ToString();

            //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //lblResultado.Text = date.Add(tempo).ToString();

            //lblResultado.Text = date.DayOfWeek.ToString();
            //lblResultado.Text = date.DayOfWeek.ToString();
            lblResultado.Text = date.DayOfYear.ToString();

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color turquesa = Color.Turquoise;
            Color prata = Color.Silver;

            //Color cor1 = Color.FromArgb(255, Color.Crimson);

            Color cor1 = Color.FromArgb(255, 80, 50, 25);
            Color cor2 = Color.FromKnownColor(KnownColor.PowderBlue);
            Color cor3 = Color.FromName("AntiqueWhite");

            lblResultado.BackColor = cor3;
            lblResultado.ForeColor = cor1;

            //Color cor4 = lblResultado.BackColor;

            //btnColor.BackColor = cor4;
            btnColor.BackColor = lblResultado.BackColor;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Times New Roman", 18, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel);
                             //"Helvetica, Arial, sans-serif"
            Font letra2 = new Font(FontFamily.GenericSerif, 20, FontStyle.Regular, GraphicsUnit.Pixel);

            lblResultado.Text = "Bem vindo ao C#, Trabalho com fontes";

            lblResultado.Font = letra;
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            //string meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Environment.CurrentDirectory = "C:\\";
            //string dirAtual = Environment.CurrentDirectory;

            //lblResultado.Text = $"{dirAtual} {Environment.NewLine} {meusDocs}";

            //string varAmb = Environment.GetEnvironmentVariable("Path");

            //string[] discos = Environment.GetLogicalDrives();


            //List<string> disks = new List<string>();
            //lblResultado.Text = "";
            //disks.AddRange(Environment.GetLogicalDrives());

            //foreach (string item in disks)
            //{
            //    lblResultado.Text += $"\n" + item;
            //}

            string user = Environment.UserName;
            string dominio = Environment.UserDomainName;
            int cpu = Environment.ProcessorCount;


            lblResultado.Text = cpu.ToString();
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            string exec = Application.ExecutablePath;

            string pasta = Application.StartupPath;

            Application.Restart();

            lblResultado.Text = pasta;
        }
    }
}
