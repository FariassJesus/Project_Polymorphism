using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using JurassicPark.src.Interfaces;

namespace JurassicPark.src
{
    internal class Espinossauro : Animal, IAlimentacao
    {
        public Espinossauro(string nome, int idade, string peso) : base(nome, idade, peso)
        {

        }
        public override void Comer()
        {
            WriteLine($"UAU!!! O {Nome} está caçando!");
        }
        public void Predominancia()
        {
            WriteLine($"O {Nome} é um carnívoro e se alimenta de outros animais");
        }
    }
}
