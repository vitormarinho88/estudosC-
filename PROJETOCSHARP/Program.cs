using CursoCSharp.Fundamentos;
using System;
   
namespace PROJETOCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //UsandoContinue.Executar();
            
            var central = new CentralDeExercicios(new Dictionary<string, Action>
            {
                { "1", EstruturaForEach.Executar},
                { "2", EstruturaDoWhile.Executar},
                { "3", EstruturaFor.Executar},
                { "4", EstruturaIF.Executar},
                { "5", EstruturaIfElse.Executar},
                { "6", EstruturaIfElseIf.Executar},
                { "7", EstruturaSwitch.Executar},
                { "8", EstruturaWhile.Executar},
                { "9", UsoBreak.Executar },
                {"10", UsandoContinue.Executar},
                {"11", VariavesEConstantes.Executar},
            
            });



            central.Executar("11");
                
                
                
            
        }


    }

    public class CentralDeExercicios
    {
        Dictionary<string, Action> Operacoes;

        public CentralDeExercicios(Dictionary<string, Action> operacoes)
        {
            Operacoes = operacoes;
        }

        public void Executar(string operacao)
        {
            Operacoes[operacao].Invoke();
        }
    }
   
}

