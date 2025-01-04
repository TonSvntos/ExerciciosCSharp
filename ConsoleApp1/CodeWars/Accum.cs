using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.CodeWars
{
    public class Accum
    {
        public static void Executar()
        {
            string s = "abcd";

            char[] array  = s.ToCharArray();

            int counter = 1;

            string secondString = string.Empty;
            string final = string.Empty;

            foreach (char c in array)
            {
                string firstString = c.ToString().ToUpper();
                if (counter > 1)
                {
                    secondString = new string(c, counter);
                    secondString = secondString.ToLower();

                    
                }

                final += c.ToString().ToUpper() + secondString + "-";
                counter++;
            }

            Console.WriteLine(final.Remove(final.Length - 1));


        }
        

        public static String Accum2(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        }

        public static string Accum3(string s)
        {
            if (s.Length < 1) return "";

            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (char c in s.ToLower())
                sb.Append(Char.ToUpper(c), 1)
                  .Append(c, count++ - 1)
                  .Append('-');

            return sb.ToString().TrimEnd('-');
        }
    }

    
}
