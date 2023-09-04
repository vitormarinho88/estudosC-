using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOCSHARP.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //Double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDecorte = 7.0;

            Console.WriteLine("Nota invalida ? {0}", nota > 10.0);
            Console.WriteLine("Nota invalida ? {0}", nota < 0.0);
            Console.WriteLine("Perfeito ? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar ? {0}", nota != 10.0);
            Console.WriteLine("Passou por media? {0}", nota >= notaDecorte);
            Console.WriteLine("Recuperação ? {0}", nota < notaDecorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);


        }
    }
}
