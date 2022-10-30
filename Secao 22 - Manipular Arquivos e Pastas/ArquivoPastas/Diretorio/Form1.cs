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

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string path = @"c:\Curso\";
            //bool res = Directory.Exists(path + "algo");
            //lista.Items.Add(res);

            //if (!res)
            //{
            //    Directory.CreateDirectory(path + "algo");
            //}

            //if (res)
            //{
            //    Directory.Delete(path + "algo");
            //}

            //if (res)
            //{
            //    Directory.Move(path + "algo", path + "destino\\algo"); //@"destino\algo"
            //}

            //string[] dirs = Directory.GetDirectories(path);

            //foreach (string dir in dirs)
            //{
            //    lista.Items.Add(dir);
            //}


            //string[] files = Directory.GetFiles(path);

            //foreach (string file in files)
            //{
            //    lista.Items.Add(file);
            //}

            //string root = Directory.GetDirectoryRoot(path);
            //lista.Items.Add(root);

            //string[] drives = Directory.GetLogicalDrives();
            //lista.Items.AddRange(drives);

            //DirectoryInfo info = Directory.GetParent(path);
            //lista.Items.Add(info.FullName);

            string dir = Directory.GetCurrentDirectory();
            lista.Items.Add(dir);
        }
    }
}
