using System;
using Encapsulamento;


namespace PROJETOCSHARP.O.O
{
    public class FilhoNaoReconhecido : Subcelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido..");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);


        }

    }
    
    public class AmigoDistante   {
        public readonly Subcelebridade amiga = new Subcelebridade();
        
        public void MeusAcessos ()  {
            Console.WriteLine("AmigoDistante");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop;


        }


    }
    
    class Encapsulamento
    {
          public static void Executar()   {
            Subcelebridade sub = new Subcelebridade();
            sub.MeusAcesso();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
          } 
        
        
        
        
        
        





    }


}	

