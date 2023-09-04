
using Encapsulamento;
using PROJETOCSHAP.API;
using PROJETOCSHAP.ClassesEMetodos;
using PROJETOCSHAP.Coleções;
using PROJETOCSHAP.EstruturaDeControle;
using PROJETOCSHAP.Exceções;
using PROJETOCSHAP.MetodosEFunçoes;
using PROJETOCSHAP.TopicosAvançados;
using PROJETOCSHARP.API;
using PROJETOCSHARP.ClassesEMetodos;
using PROJETOCSHARP.Fundamentos;

using PROJETOCSHARP.MetodosEFunçoes;
using PROJETOCSHARP.O.O;
using PROJETOCSHARP.TopicosAvançados;
using System;
using Array = PROJETOCSHAP.Coleções.Array;

namespace PROJETOCSHARP
{

    
        

    class Program
    {
        static void Main(string[] args)
        {
          

            //Console.WriteLine("Hello world");
            //UsandoContinue.Executar

            var central = new CentralDeExercicios(new Dictionary<string, Action>
            {      
                //estrutura de controle 

                { "1", EstruturaForEach.Executar},
                { "2", EstruturaWhile.Executar},
                { "3", EstruturaFor.Executar},
                { "4", EstruturaIF.Executar},
                { "5", EstruturaIfElse.Executar},
                { "6", EstruturaIfElseIf.Executar},
                { "7", EstruturaSwitch.Executar},
                { "8", EstruturaWhile.Executar},
                { "9", UsoBreak.Executar },
                {"10", UsandoContinue.Executar},

                         
                       //fundamentos 
                       
                
                {"12", Comentarios.Executar },
                {"13", Conversoes.Executar },
                {"14", FormantandoNumero.Executar },
                {"15", Interpolçao.Executar },
                {"16", LendoDados.Executar },
                {"17", Notaçaoponto.Executar},
                {"18", OperadoresAritimeticos.Executar },
                {"19", OperadoresAtribuiçao.Executar },
                {"20", OperadoresLogicos.Executar },
                {"21", OperadoresUnarios.Executar },
                {"22", OperadorTernario.Executar },
                {"76", OperadoresRelacionais.Executar },
                {"77", Inferencia.Executar },



                //classes e metodos 

                {"23", Membro.Executar },
                {"24", Construtores.Executar },
                {"25", MetodosComRetorno.Executar },
                {"26", MetodosEstaticos.Executar },
                {"27", AtributosEstaticos.Executar},
                {"28", DesafioAtributo.Executar },
                {"29", Params.Executar },
                {"30", ParametrosNomeados.Executar },
                {"32", Props.Executar },
                {"33", ReadOnly.Executar },
                {"34", ExemploEnum.Executar },
                {"35", ExStrutc.Executar },
                {"36", StructVsClasse.Executar },
                {"37", ValorVsReferencia.Executar },
                {"38", RefOut.Executar },
                {"39", ParametroPadrao.Executar },
                {"75", GetSet.Executar },
                
                //Coleçoes
                
                {"40", Array.Executar },
                {"41", ColecsList.Executar },
                {"42", ColecArrayList.Executar },
                {"43", ColecSet.Executar},
                {"44", ColecQueue.Executar },
                {"45", igualdade.Executar },
                {"46", ColeçoesStack.Executar },
                {"47", ColecsDictionary.Executar },
                
                
                //Orientação ao Objeto...
                
                
                {"48", Herança.Executar },
                {"49", ConstrutorThis.Executar },
                {"78", Dynamics.Executar }, 
                {"50", AmigoProximo.Executar },
                {"51", Polimorfismo.Executar },
                {"52", Abstract.Executar },
                {"53", Interface.Executar },
                {"54", Sealed.Executar },
                {"79", FilhoReconhecido.Executar },
                {"80", Subcelebridade.Executar },

                //Metodo e Funçoes

                {"55", Lambda.Executar },
                {"56", LambdaDelegate.Executar },
                {"57", UsandoDelegate.Executar },
                {"58", DelegateComoParametros.Executar },
                {"59", MetodosDeExtensao.Executar },



                // Exceções 

                {"60", PrimeiraExceçao.Executar },
                {"61", ExceçoesPersonalizadas.Executar },

                //API

                {"62", primeiroArquivo.Executar },
                {"63", Lendados.Executar },
                {"64", ExemploFileInfo.Executar },
                {"65", Diretorios.Executar },
                {"66", ExemploDirectoryInfo.Executar },
                {"67", ExemploPath.Executar },
                {"68", ExDateTime.Executar },
                {"69", ExDateTime.Executar },


                //TOPICOS AVANÇADOS

                {"70", LINQ1.Executar },
                {"71", LINQ2.Executar },
                {"72", Nullables.Executar },
                {"73", Dynamics.Executar },
                {"74", Genericos.Executar },

            }); ; ; ;





            central.Executar("72");



            
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

