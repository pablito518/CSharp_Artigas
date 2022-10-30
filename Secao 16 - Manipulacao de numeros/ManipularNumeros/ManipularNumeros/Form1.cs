using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region TryParse
            //int num;
            //bool res = int.TryParse("2002", out num);
            //int.TryParse("2002", out num);

            //if (int.TryParse("2002", out num))
            //{
            //    lblResultado.Text = num.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = "Erro na conversão";
            //}
            //lblResultado.Text = num.ToString();
            #endregion

            #region ToString / Convert.ToString
            //int num = 120;
            //lblResultado.Text = num.ToString("00000");
            //lblResultado.Text = num.ToString("00000.00");

            //double num = 120.5524;
            //lblResultado.Text = num.ToString("00000.00");
            //lblResultado.Text = num.ToString("#.00");

            //int num = 11;
            //lblResultado.Text = num.ToString("x"); //Formato hexadecimal minúsculo
            //lblResultado.Text = num.ToString("X"); //Formato hexadecimal maiúsculo
            //lblResultado.Text = num.ToString("X5"); //Formato hexadecimal maiúsculo, minímo 2 dígitos

            //lblResultado.Text = num.ToString("D"); //Formato decimal  
            //lblResultado.Text = num.ToString("C"); //Formato Monetário

            //lblResultado.Text = Convert.ToString(num, 16);
            #endregion

            #region Classe Math
            //double pi = Math.PI;
            //double E = Math.E;
            //double sen = Math.Sin(3);
            //double cos = Math.Cos(3);
            //double tg = Math.Tan(3);
            //double potencia = Math.Pow(2, 2);
            //double raizQuadrada = Math.Sqrt(49);
            //double arredonda = Math.Round(158.75);
            //double inteiro = Math.Truncate(32.57);
            //double floor = Math.Floor(52.75);
            //double ceiling = Math.Ceiling(52.75);


            //lblResultado.Text = ceiling.ToString("#.00");

            #endregion
        }
    }
}
