using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_andar_e_pulas
{
    class Player
    {
        public Byte Posição { set; get; }
        public String Aparência { set; get; }
        public String FacingRight { set; get; }
        public String FacingLeft { set; get; }
        public Boolean Pulando { set; get; }


        public Player(String right, String left)
        {
            Posição = 0;
            FacingRight = right;
            FacingLeft = left;
            Aparência = FacingRight;
            Pulando = false;
        }


        public void pular()
        {

            Console.Beep(234, 100);
        }


        public void andar(Boolean direção, byte limite)
        {
            if (direção)
            {

                if (Posição < limite)
                {

                    Posição++;
                    Aparência = FacingRight;
                }

            }
            else
            {
                if (Posição > 0)
                {
                    Posição--;
                    Aparência = FacingLeft;
                }
            }

        }
    }
}