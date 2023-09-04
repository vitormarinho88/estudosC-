using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public  class FilhoReconhecido  : Subcelebridade 
    {
          public new void MeusAcessos()   {

            Console.WriteLine("FilhosReconhecido..");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            //Console.WriteLne(UsaMuitoPhotoshop);

          }
    
    
          public static void Executar()
          {

            var filhoreconhecido = new FilhoReconhecido();
            filhoreconhecido.MeusAcessos();
          }
    
    
    }

      
    

     
}
