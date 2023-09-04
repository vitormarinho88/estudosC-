using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class Subcelebridade   {

        // Todos
        public string InfoPublica = "Tenho um instagram!";

        //herança
        protected string CorDoOlho = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCelular = 55119999999999;

        //herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso Muitas Girias";

        // mesma class ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "teu cu 123";

        // private é o padrão 
        bool UsaMuitoPhotoshop = true;

        public void MeusAcesso()    {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    
       
        public static void Executar()
        {
            var subcelebridade = new Subcelebridade();
            subcelebridade.MeusAcesso();

        }

    }






}