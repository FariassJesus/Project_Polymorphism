using System;
using static System.Console;
using JurassicPark.src;
using JurassicPark.src.Interfaces;

namespace JurassicPark
{
    class Program
    {

        static void Main(string[] args)
        {
            WriteLine("Bem vindo ao Jurassic Park");
            WriteLine("Para Listar nossas atrações digite 1");
            WriteLine("Para sair de nosso parque digite outra tecla");

            Espinossauro Spino = new Espinossauro("Espinossauro", 20, "7 toneladas");
            Triceratops Trice = new Triceratops("Triceratops", 19, "9 toneladas");
            Pterossauro Ptero = new Pterossauro("Pterossauro", 18, "200 KG");
            Mosassauro Mosa = new Mosassauro("Mosassauro", 21, "6 toneladas");

            string opUser = ReadLine();

            while (opUser == "1")
            {
                if (opUser != "1")
                {
                    WriteLine("Saindo do parque");
                    break;
                }
                WriteLine("Escolha a atração que deseja assistir");
                WriteLine("Para dinos terrestres digite 1");
                WriteLine("Para dinos aquáticos digite 2");
                WriteLine("Para dinos voadores digite 3");

                string opDino = ReadLine();

                switch (opDino)
                {
                    case "1":
                        Trice.Dormir();
                        Trice.Predominancia();
                        WriteLine($"Pesa cerca de: {Trice.Peso}\n");
                        WriteLine("Para voltar ao menu anterior digite 1 e para sair digite 0");
                        opUser = ReadLine();
                        break;
                    case "2":
                        Spino.Comer();
                        Spino.Predominancia();
                        WriteLine($"Pesa cerca de: {Spino.Peso}\n");
                        WriteLine("Uma curiosidade: O Espinossauro tem como habitate natural predominante o mar, mas também podia caçar em terra firme");
                        Mosa.Saltar();
                        Mosa.Comer();
                        WriteLine($"Pesa cerca de: {Mosa.Peso}\n");
                        WriteLine("Para voltar ao menu anterior digite 1 e para sair digite 0");
                        opUser = ReadLine();
                        break;
                    case "3":
                        Ptero.Voar();
                        Ptero.Comer();
                        WriteLine($"Pesa cerca de: {Ptero.Peso}\n");
                        WriteLine("Para voltar ao menu anterior digite 1 e para sair digite 0");
                        opUser = ReadLine();
                        break;
                    default :
                        WriteLine("Valor inválido!!!");
                        WriteLine("Para voltar ao menu anterior digite 1 e para sair digite 0");
                        opUser = ReadLine();
                        break;

                }
                
            }
        }
    }
}
