using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.CodeWars
{
    public class BuildTower
    {
        public static void Executar()
        {
            int nFloors = 4;
            string resultado = string.Empty;

            if(nFloors > 0)
            {
                var sb = new StringBuilder();
                sb.Append('*');
                for (int i = 2; i < nFloors; i++)
                {
                    
                    //sb.AppendLine('*', 2);

                }

                resultado = sb.ToString();
            }

            Console.WriteLine(resultado);

        }
    }
}
