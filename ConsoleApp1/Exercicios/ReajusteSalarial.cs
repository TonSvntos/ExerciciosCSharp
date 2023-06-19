using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.Exercicios
{
    internal class ReajusteSalarial
    {
        public static void Executar()
        {
            // Escrever um algoritmo para uma empresa que decide dar um reajuste a seus 584 funcionarios de acordo com os seguintes criterios
            // a) 50% para aqueles que ganham menos do que três salarios minimos.
            // b) 20% para aqueles que ganham entre três até dez salarios minimos.
            // c) 15% para aqueles que ganham acima de dez até vinte salarios minimos.
            // d) 10% para os demais funcionarios.
            const double salarioMinimo = 1100;
            int valorReajuste;

            Console.WriteLine("Insira seu salário para ver o reajuste: ");
            double insertSalario = int.Parse(Console.ReadLine());

            switch (insertSalario)
            {
                case < salarioMinimo * 3:
                    valorReajuste = 50;
                     
                    break;
                case < salarioMinimo * 10:
                    valorReajuste = 20;

                    break;
                case < salarioMinimo * 20:
                    valorReajuste = 15;

                    break;
                default:
                    valorReajuste = 10;

                    break;
            }

            Console.WriteLine($"Seu reajuste foi de {valorReajuste}%");
        }
    }
}
