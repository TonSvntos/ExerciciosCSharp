using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.IfElse
{
    public class NegativoOuNao
    {
        public static void Executar()
        {
            Console.WriteLine("Escreva um número: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0)
            {
                Console.WriteLine("Este número é negativo.");
            }
            else
            {
                Console.WriteLine("Este número é positivo");
            }

        }
    }
}
