using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.Exercicios
{
    internal class IguaisEDiferentes
    {
        public static void Executar()
        {
            //Faça um algoritmo que leia dois números e identifique se são iguais ou diferentes
            // Caso eles sejam iguais, Imprima uma mensagem dizendo que são iguais.
            // caso diferentes, informe qual número é o maior e uma mensagem dizendo que são diferentes

            Console.WriteLine("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("O dois números são iguais.");
            }
            else
            {
                if(numero1 < numero2)
                {
                    Console.WriteLine("O primeiro número é menor que o segundo número.");
                }
                else
                {
                    Console.WriteLine("O primeiro número é maior que o segundo número.");
                }
            }


        }
    }
}
