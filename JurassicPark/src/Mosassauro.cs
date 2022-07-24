using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using JurassicPark.src.Interfaces;

namespace JurassicPark.src
{
    internal class Mosassauro : Animal, IAlimentacao
    {
        public Mosassauro (string nome, int idade, string peso) : base(nome, idade, peso)
        {
        }
        public void Saltar()
        {
            WriteLine($"O {Nome} saltou para fora do mar!!!");
        }
        public void Predominancia()
        {
            WriteLine($"O {Nome} é um dinossauro carnívoro e se alimenta de peixes e moluscos");
        }

    }
}
