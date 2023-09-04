using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOCSHARP.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executoutrabalho1 = true;
            var executoutrabalho2 = false;

            bool comprouTV50 = executoutrabalho1 && executoutrabalho2;
            Console.WriteLine("comprou a tv 50? {0}", comprouTV50);

            var comprousorvete = executoutrabalho1 || executoutrabalho2;
            Console.WriteLine("comprou o sorvete? {0}", comprousorvete);

            var comprouTV32 = executoutrabalho1 ^ executoutrabalho2;
            Console.WriteLine("comprou a tv 32 ? {0}", comprouTV32);

            Console.WriteLine("Mais saudavel ? {0}", comprousorvete);









        }


    }

}


