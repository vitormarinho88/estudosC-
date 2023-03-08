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
                //estrutura de controle 

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

                         
                       //fundamentos 
                       
                {"11", VariavesEConstantes.Executar},
                {"12", Comentarios.Executar },
                {"13", Conversoes.Executar },
                {"14", FormantandoNumero.Executar },
                {"15", Interpolçao.Executar },
                {"16", LendoDados.Executar },
                {"17", notaçaoponto.Executar},
                {"18", OperadoresAritimeticos.Executar },
                {"19", OperadoresAtribuiçao.Executar },
                {"20", OperadoresLogicos.Executar },
                {"21", OperadoresUnarios.Executar },
                {"22", OperadorTernario.Executar },


                //classes e metodos 

                {"23", Membro.Executar },
                {"24", Construtores.Executar },
                {"25", MetodosComRetorno.Executar },
                {"26", MetodosEstaticos.Executar },
                {"27", AtributosEstaticos.Executar},
                {"28", DesafioAtributo.Executar },
                {"29", Params.Executar },
                {"30", ParametrosNomeados.Executar },
                {"31", GetSet.Executar},
                {"32", Props.Executar },
                {"33", ReadOnly.Executar },
                {"34", ExEnum.Executar },
                {"35", ExStrutc.Executar },
                {"36", StructVsClasse.Executar },
                {"37", ValorVsReferencia.Executar },
                {"38", RefOut.Executar },
                {"39", ParametroPadrao.Executar },
            
            
            
            
            }) ; 



            central.Executar("39");
                
                
                
                
            
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

