using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exercicios
{
    internal class MenuComTresOpcoesDeSoma
    {
        public static void Executar()
        {
            //Desenvolva um algoritmo que mostre um menu de opcoes para 
            // calcular a soma de todos os números compreendidos entre 1 e 100.
            // Calcular a soma de todos os números pares entre 1 e 100.
            // Calcular a soma de todos os números divisiveis por 3 entre 1 e 100.

            int soma = 0;


            Console.WriteLine(@"Escolha uma das opcoes abaixo: 
                1 - calcular a soma de todos os numeros entre 1 e 100.
                2 - calcular a soma de todos os numeros pares entre 1 e 100.
                3 - calcular a soma de todos os numeros divisiveis por 3 entre 1 e 100.");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    for (int i = 1; i < 100; i++)
                    {
                        soma += i;
                    }
                    break;

                case 2:
                    for (int i = 1; i < 100; i++)
                    {
                        if (i % 2 == 0)
                        {
                            soma += i;
                        }
                    }
                    break;

                case 3:
                    for (int i = 1; i < 100; i++)
                    {
                        if (i % 3 == 0)
                        {
                            soma += i;
                        }
                    }
                    break;

            }

            Console.WriteLine(soma);
        }
    }
}
