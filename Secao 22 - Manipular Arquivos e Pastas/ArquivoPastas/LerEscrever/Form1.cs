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

namespace LerEscrever
{
    public partial class Form1 : Form
    {
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscreverTxt_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();

            string path = @"C:\Curso\Teste\file.txt";

            StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8);

            //writer.WriteLine(txtConteudo.Text);

            writer.Write(txtConteudo.Text);

            writer.Flush();
            writer.Dispose();
            writer.Close();

            //string path = @"C:\Curso\Teste\file.txt";

            //StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8);

            //string log = $"Log iniciado em {DateTime.Now.ToShortDateString()}";
            //writer.Flush();
            //writer.Dispose();
            //writer.Close();
            //WriteToFile(path, log);

            //writer.Flush();
            //writer.Dispose();
            //writer.Close();
        }

        private void btnLerTxt_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            string path = @"C:\Curso\Teste\file.txt";
            StreamReader reader = new StreamReader(path, true);
            //string txt = reader.ReadToEnd();

            //string linha = reader.ReadLine();
            //linha += reader.ReadLine();
            //linha += reader.ReadLine();

            //string linha = reader.ReadLine();

            //while (linha != null)
            //{
            //    txtConteudo.Text += $"{linha}\n";
            //    linha = reader.ReadLine();
            //}

            //txtConteudo.Text = linha;
            //reader.Close();

            while (!reader.EndOfStream)
            {
                //char c = (char)reader.Read();
                //txtConteudo.Text = c;
                txtConteudo.Text += (char)reader.Read();
            }
        }

        private void btnLerBinary_Click(object sender, EventArgs e)
        {
            string path = @"C:\Curso\Teste\file.txt";
            FileStream file = File.OpenRead(path);
            BinaryReader reader = new BinaryReader(file);

            //while (reader.BaseStream.Position != reader.BaseStream.Length)
            //{
            //    byte b = reader.ReadByte();
            //    txtConteudo.Text += $"{b} ";
            //    txtConteudo.Text += $"{(char)b}";
            //}
            //reader.Close();

            //buffer = reader.ReadBytes((int)reader.BaseStream.Length);

            //foreach (byte b in buffer)
            //{
            //    txtConteudo.Text += (char)b;
            //}

            reader.Close();
            buffer = File.ReadAllBytes(path);
            foreach (byte b in buffer)
            {
                txtConteudo.Text += (char)b;
            }
        }

        private void btnEscreverBinary_Click(object sender, EventArgs e)
        {
            string path = @"C:\Curso\Teste\fileNovo.txt";
            FileStream file = File.OpenWrite(path);
            BinaryWriter writer = new BinaryWriter(file);

            writer.Write(buffer);

            writer.Flush();
            writer.Dispose();
            writer.Close();
        }

        //public static void WriteToFile(string Path, string Text)
        //{
        //    string content = File.ReadAllText(Path);
        //    content = Text + "\n" + content;
        //    File.WriteAllText(Path, content);
        //}
    }
}
