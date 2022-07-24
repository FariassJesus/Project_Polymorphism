using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JurassicPark.src
{
    internal class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Peso { get; set; }

        public Animal(string nome, int idade, string peso)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
        }

        public virtual void Comer()
        {
            WriteLine($"{Nome} está se alimentando");
        }
        public virtual void Dormir()
        {
            WriteLine($"{Nome} está dormindo");
        }
    }
}
