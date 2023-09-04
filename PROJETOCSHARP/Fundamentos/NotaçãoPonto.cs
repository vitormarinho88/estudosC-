using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOCSHARP.Fundamentos
{
    class Notaçaoponto
    {
        public static void Executar()
        {
            var saudaçao = "Olá".ToUpper().Insert(3, "World!")
                .Replace("World!", "mundo!");
            Console.WriteLine(saudaçao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);


        }
    }




}
