using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExerciciosCSharp.IfElse
{
    public class ImparPar
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número: ");
            int n1 = Int32.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}
