using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.Matriz
{
    public class PercorrerMatriz
    {
        public static void Executar()
        {

            /*
            Fazer um programa para ler um número inteiro N e uma matriz de
            ordem N contendo números inteiros. Em seguida, mostrar a diagonal
            principal e a quantidade de valores negativos da matriz.
            */

            Console.WriteLine("Escreva o valor da matriz");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(matriz[i, i] + " ");
            }
            


        }
    }
}
