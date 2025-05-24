using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    public class Dice
    {
        public string LadoSorteado;
        public int FaceParaCima;
        public int FaceParaBaixo;
        public int QuantidadeDeFaces;

        public Dice(int faces)
        {
            QuantidadeDeFaces = faces;
        }
        public Dice()
        {
            QuantidadeDeFaces = 6;
        }

        public void Sortear()
        {
            Random random = new Random();
            FaceParaCima = random.Next(1, QuantidadeDeFaces + 1);
            FaceParaBaixo = 1 + QuantidadeDeFaces - FaceParaCima;
        }

        public string Roller(int pickerSelect)
        {
            Random random = new Random();
            FaceParaCima = random.Next(1, QuantidadeDeFaces + 1);
            FaceParaBaixo = 1 + QuantidadeDeFaces - FaceParaCima;

            if (FaceParaCima == pickerSelect)
            {
                LadoSorteado = "Você acertou!";
            }
            else
            {
                LadoSorteado = "Você errou!";
            }

            return LadoSorteado;
        }
    }
}
