using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOCSHARP.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 9.0;
            bool bomComportamneto = true;
            string resultado = nota >= 7.0 && bomComportamneto ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);

        }



    }
}
