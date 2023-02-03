using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOCSHARP
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            // preço desconto
            var preço = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preço + imposto;
            var totalcomDesconto = total - (total * desconto);
            Console.WriteLine("o preço final é {0}", totalcomDesconto);


            //imc 
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("$ IMC é {imc}.");

            //Numero par / impar
            int par = 24;
            int impar = 55;

            Console.WriteLine("{0}/2 tem resto {1]", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}",impar, impar % 2);





        }
    }
}