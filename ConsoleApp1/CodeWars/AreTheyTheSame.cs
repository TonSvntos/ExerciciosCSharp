using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.CodeWars
{
    public class AreTheyTheSame
    {
        public static void Executar()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };


            //if (a is null || b is null)
            //    return false;

            a.ToList().Sort();

            b.ToList().Sort();

            foreach(int i in a )
            {

            }


        }
    }
}
