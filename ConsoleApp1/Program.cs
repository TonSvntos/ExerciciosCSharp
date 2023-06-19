using ExerciciosCSharp.Exercicios;
using ExerciciosCSharp.IfElse;

namespace Program
{

    class Program

    {

        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                { "1 - Menu com 3 opcoes de soma.", MenuComTresOpcoesDeSoma.Executar },
                { "2 - Iguais e Diferentes", IguaisEDiferentes.Executar },
                { "3 - Reajuste Salarial", ReajusteSalarial.Executar },
                { "4 - Matriz", Matriz.Executar },
                { "5 - Receber 15 valores", Receber15Valores.Executar },

                //If Else

                { "6 - Número negativo ou não", NegativoOuNao.Executar  },
                { "7 - Número par ou impar", ImparPar.Executar  },



            }) ;

            central.SelecionarEExecutar();
        }
    }
}