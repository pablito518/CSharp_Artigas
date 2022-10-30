using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Contains / ToString
            //string texto = "Este tipo de variável é alfanumérica.";

            //if (texto.Contains("tipo"))
            //{
            //    label1.Text = "Contém";
            //}
            //else
            //{
            //    label1.Text = "Não contém";
            //}

            //int num = 5400;
            //bool res = true;

            //label1.Text = num.ToString();
            //label1.Text = res.ToString();
            #endregion

            #region ToUpper / ToLower
            //string nome = "Pablo";

            //nome = nome.ToUpper();

            //label1.Text = nome.ToUpper(); //tudo maiúsculo

            //label1.Text = nome.ToLower(); //tudo minúsculo
            #endregion

            #region IndexOf / LastIndexOf
            //string nome = "Pablo Ribeiro";

            //int indice = nome.IndexOf('o');

            //int indice = nome.IndexOf("blo");

            //int indice = nome.IndexOf('o', 5);

            //int indice = nome.IndexOf('o', 5, 4);

            //label1.Text = $"Indice: {indice}";

            //label1.Text = nome.IndexOf('o').ToString();

            //int indice = nome.LastIndexOf('o');

            //label1.Text = $"Indice: {indice}";
            #endregion

            #region Insert / Replace
            //string nome = "Pablo";

            //string nomeFinal = nome.Insert(5, " Rodrigo");

            //string nomeFinal = nome.Replace('o',  'i');

            //string nomeFinal = nome.Replace("Pablo", "Rodrigo");

            //label1.Text = nomeFinal;
            #endregion

            #region Length / SubString
            //string nome = "Pablo Ribeiro";

            //int tam = nome.Length;

            //label1.Text = $"O nome {nome} contém {tam} letras";

            /********** UTILIZANDO O FOR **************
            for (int i = 0; i < nome.Length; i++)
            {
                label1.Text += $"{nome[i]}\n";
            }
            */

            /********* UTILIZANDO O FOREACH ************
            foreach (char letra in nome)
            {
                label1.Text += $"{letra}\n";
            }
            */

            // string parte = nome.Substring(6);

            // string parte = nome.Substring(0,5);

            //string parte = nome.Substring(nome.IndexOf(" "));

            //label1.Text = parte;
            #endregion

            #region Split
            //string nomes = "Pablo Rodrigo Emílio Escobar Gavíria Neruda Picasso";
            //char[] separador = { ' ' };
            //string[] resultado = nomes.Split(separador); //ou (' ')

            //foreach (string nome in resultado)
            //{
            //    label1.Text += $"{nome}\n";
            //}

            //string nomes = "Pablo_+_Rodrigo_+_Emílio_+_Escobar_+_Gavíria_+_Neruda_+_Picasso";
            //string[] separador = { "_+_" };
            //string[] resultado = nomes.Split(separador, StringSplitOptions.None);
            //foreach (string nome in resultado)
            //{
            //    label1.Text += $"{nome}\n";
            //}

            //string nomes = "Pablo_Rodrigo Emílio-Escobar-Gavíria Neruda_Picasso";
            //char[] separador = { ' ', '-', '_' };
            //string[] resultado = nomes.Split(separador);
            //foreach (string nome in resultado)
            //{
            //    label1.Text += $"{nome}\n";
            //}

            #endregion

            #region StartWith / EndsWith
            //string nome = "Pablo";

            //bool res = nome.StartsWith("pab"); //ou "P"
            //bool res = nome.StartsWith("pab", StringComparison.OrdinalIgnoreCase);

            //bool res = nome.EndsWith("lo");
            //bool res = nome.EndsWith("LO", StringComparison.OrdinalIgnoreCase);
            //if (res)
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}
            #endregion

            #region Trim / TrimStart / TrimEnd
            //string mensagem = "     Ola Pablo    ";
            // string mensagem = "  -_-   Ola Pablo 555-   ";

            // char[] c = { ' ', '-', '_', '5' };
            //  string nova = mensagem.Trim(c);

            //label1.Text = $">{mensagem.Trim()}<";
            //label1.Text = $">{mensagem.TrimStart()}<";
            //label1.Text = $">{mensagem.TrimEnd()}<";
            #endregion

            #region CompareTo / Equals
            //string nome = "Pablo";
            //string nome2 = "pablo";
            //string nome3 = "Rodrigo";

            //if (nome.Equals(nome2, StringComparison.OrdinalIgnoreCase))
            //{
            //    label1.Text = "Certin";

            //}
            //else
            //{
            //    label1.Text = "Deu ruim";
            //}

            //if(nome.Equals(nome2))
            //{
            //    label1.Text = "Certin";
            //}
            //else
            //{
            //    label1.Text = "Deu ruim";
            //}


            //label1.Text = nome.CompareTo(nome).ToString();
            #endregion

            #region Format
            //decimal valor = 19.95m;
            //int temp = 32;

            //string s = String.Format("O valor do produto é {0:N1}" e a temperatura é {1}, valor, temp);
            //string s =  $"O valor do produto é {valor:F3} e a temperatura é {temp}";
            //string s = $"O valor do produto é {valor:C2} e a temperatura é {temp}";

            //string s = String.Format("Hoje é {0:d} e são {0:t}", DateTime.Now);
            //string s = String.Format("Hoje é {0:D} e são {0:T}", DateTime.Now);
            
            //string s = $"O valor do produto é {valor:C2} e a temperatura é {temp}";

            //string s = $"Data: {DateTime.Now:D} e hora {DateTime.Now:T}";


            //label1.Text = s;
            #endregion
        }
    }
}
