using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JurassicPark.src.Interfaces;
using static System.Console;

namespace JurassicPark.src
{
    internal class Triceratops : Animal, IAlimentacao
    {
        public Triceratops(string nome, int idade, string peso) : base(nome, idade, peso)
        {

        }
        public override void Dormir()
        {
            WriteLine($"O {Nome} está dormindo");
        }
        public void Predominancia()
        {
            WriteLine($"O {Nome} do tipo herbívoro e se alimenta de plantas");
        }
    }
}
