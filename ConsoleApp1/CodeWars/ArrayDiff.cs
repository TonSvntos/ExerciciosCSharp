using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.CodeWars
{
    public class ArrayDiff
    {

        /*
         Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

        It should remove all values from list a, which are present in list b keeping their order.

        Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}

        If a value is present in b, all of its occurrences must be removed from the other:

        Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}

         */
        public static void Executar()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, };

            int[] b = { 1, 2, 3, 6, };


            int[] diffArray = new int[a.Length];

          
        }
    }
}
