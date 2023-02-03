using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOCSHARP
{
    class notaçaoponto
    {
        public static void Executar()
        {
            var saudaçao = "Olá".ToUpper().Insert(3, "World!")
                .Replace("World!", "mundo!");
            Console.WriteLine(saudaçao);

            Console.WriteLine("Teste".Length);

            String valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

           
        }
    }


    
    
}
