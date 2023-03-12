using ConsoleApp1.Exercicios;

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

            }) ;

            central.SelecionarEExecutar();
        }
    }
}