using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    internal class Contador
    {
        public int Sequencia;
        public int Pontos;
        public int Limite;
        public int Venceu;


        //Comparar se o selecionado é igual a faceParaCima do dado do jogador 
        //Se for igual o jogador venceu.
        //Somo um ponto
        //Se ele tinha vencido o duelo anterior, soma 1 na sequencia
        //Se não, 0 a sequencia

        public void Jogar(Dice dadoJogador, int numeroSelecionado)
        {
           
        }
    }
}

