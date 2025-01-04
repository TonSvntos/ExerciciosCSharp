using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExerciciosCSharp.CodeWars
{
    public class Disemvowel
    {
    //Trolls are attacking your comment section!

    //A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

    //Your task is to write a function that takes a string and return a new string with all vowels removed.

    //For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

    //Note: for this kata y isn't considered a vowel.

        public static void Executar()
        {
            string frase = "This website is for losers LOL!";

            string[] vowels = { "a", "e", "i", "o", "u" };

            foreach (var vowel in vowels)
            {

                char[] fraseTeste = frase.ToLower().ToCharArray();
                foreach (char c in fraseTeste)
                {
                    if (c == char.Parse(vowel))
                        fraseTeste.Skip(c);
                }

                frase.Contains(vowel);
                frase = frase.Replace(vowel, "");
            }

            Console.WriteLine(frase);
        }

        public static string DisemvowelRegex(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }

        public static string DisemvowelLinq(string str)
        {
            return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
        }
    }
}
