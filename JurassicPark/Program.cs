using System;
using static System.Console;

namespace JurassicPark
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bem vindo ao Jurassic Park");
            WriteLine("Para Listar nossas atrações digite 1");
            WriteLine("Para sair de nosso parque digite 2");

            string opUser = ReadLine();

            while (opUser == "1")
            {
                WriteLine("Escolha sua atração que deseja assistir");
                WriteLine("Para dinos voadores digite 1");
                WriteLine("Para dinos aquáticos digite 2");
                WriteLine("Para dinos terrestres digite 3");

                string opDino = ReadLine();

                switch (opDino)
                {
                    case "1":
                        
                }
            }
        }
    }
}
