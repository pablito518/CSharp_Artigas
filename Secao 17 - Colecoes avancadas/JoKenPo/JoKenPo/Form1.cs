using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btnLagarto_Click(object sender, EventArgs e)
        {
            StartGame(3);
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            StartGame(4);
        }

        private void StartGame(int opcao)
        {
            lblResultado.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você venceu!";
                    goto default;
                case Game.Resultado.Perder:
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você Perdeu!";
                    goto default;
                case Game.Resultado.Empatar:
                    lblResultado.Visible = true;
                    lblResultado.Text = "Empatou!";
                    goto default;
                default:
                    picPlayer.Image = jogo.imgJogador;
                    picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                    picPc.Image = jogo.imgPc;
                    picPc.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }
    }
}
