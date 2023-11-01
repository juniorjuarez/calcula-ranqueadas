using calcula_ranckeadas;
using System;

namespace clacula_ranckeadas {

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=============================================================================");
            Console.WriteLine("========================= Calculadora de ranqueadas =========================");
            Console.WriteLine("Informe a quantidade de vitorias e de derrotas! ");
            Console.Write("Vitorias: ");
            int vitoria = int.Parse(Console.ReadLine());

            Console.Write("Derrotas: ");
            int derrotas = int.Parse(Console.ReadLine());

            Usuario_ranqueada.calculaRanqueadas(vitoria, derrotas);


        }
    }
    
    }