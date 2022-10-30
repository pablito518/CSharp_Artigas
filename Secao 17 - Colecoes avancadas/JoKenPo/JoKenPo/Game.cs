using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("imagens/spock-icon-4.jpg"),
            Image.FromFile("imagens/spock-icon-3.jpg"),
            Image.FromFile("imagens/spock-icon-5.jpg"),
            Image.FromFile("imagens/spock-icon-2.jpg"),
            Image.FromFile("imagens/rock-paper-scissors-icon-6.jpg")
        };

        public Image imgPc { get; private set; }
        public Image imgJogador { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPc();

            imgJogador = images[jogador];
            imgPc = images[pc];

            if(jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && pc == 2)  || (jogador == 0 && pc == 4) || (jogador == 1 && pc == 0) || (jogador == 1 && pc == 4) || (jogador == 2 && pc == 1) || (jogador == 2 && pc == 3) || (jogador == 3 && pc == 1) || (jogador == 3 && pc == 4) || (jogador == 4 && pc == 0) || (jogador == 4 && pc == 2))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }
     

        }

        private int JogadaPc()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 200)
            {
                return 0;
            }
            else if (mil >= 200 && mil <= 400)
            {
                return 1;
            }
            else if (mil >= 400 && mil <= 600)
            {
                return 2;
            }
            else if (mil >= 600 && mil <= 800)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}
