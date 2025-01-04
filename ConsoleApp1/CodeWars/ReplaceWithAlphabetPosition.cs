using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExerciciosCSharp.CodeWars
{
    public class ReplaceWithAlphabetPosition
    {
        public static void Executar()
        {


            // Texto de exemplo
            string texto = "Olá, mundo! Este é um texto com espaços e caracteres especiais.";

            // Expressão regular para capturar letras
            string regex = "[A-Za-z]+";

            // Criando um objeto Regex
            Regex pattern = new Regex(regex);

            // Obtendo as correspondências na string
            MatchCollection matches = pattern.Matches(texto);

            // Imprimindo as letras no console
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }




            //string text = "teste";

            //const string pattern = @"/([A-Za-zÀ-ÿ] +)(\s[A-Za-zÀ-ÿ]+)+/g";

            //Console.Write("teste 1" + Regex.Match(text, pattern));










            //inicializando array com as letras do alfabeto
            //string CompleteAlphabet = "abcdefghijklmnopqrstuvwxyz";
            //char[]  alphabet = CompleteAlphabet.ToCharArray();

            ////transforma o input em uma array
            //char[] inputToArray = text.ToLower().ToCharArray();


            //string ret = "";

            //foreach (char c in inputToArray)
            //{
            //    int index = Array.FindIndex(alphabet, x => x == c) + 1;
            //    Console.WriteLine(index);
            //    ret += index.ToString() + ",";

            //}

            //Console.WriteLine(ret);

            //ret = ret.Replace(",", " ");

            //Console.WriteLine(ret);



        }
    }
}
