using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace calcula_ranckeadas
{
    internal class Usuario_ranqueada
    {
        public static void calculaRanqueadas(int a, int b)
        {
            int result = a - b;

            if (result > 0)
            {
                Console.WriteLine($"Seu saldo é positivo, total de vitorias maior que de derrotas, resultado: {result}");
            }
            else if (result == 0)
            {
                Console.WriteLine("Resultado zerado, total de vitorias igual a de derrotas");

            }
            else {
               
                Console.WriteLine($"Resultado negativo, valor: {result}");
            }
            
        }
    }
}
