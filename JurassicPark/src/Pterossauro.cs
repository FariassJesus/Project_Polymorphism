using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using JurassicPark.src.Interfaces;

namespace JurassicPark.src
{
    internal class Pterossauro : Animal, IAlimentacao
    {
        public Pterossauro(string nome, int idade, string peso) : base(nome, idade, peso)
        {

        }
        public void Voar()
        {
            WriteLine($"WOW! O {Nome} voa muito rápido!");
        }
        public void Predominancia()
        {
            WriteLine($"O {Nome} é um carnívoro e também se alimenta de peixes, moluscos e carcaças");
        }


    }
}
