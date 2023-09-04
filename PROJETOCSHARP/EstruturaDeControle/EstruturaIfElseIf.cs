using System;


namespace PROJETOCSHAP.EstruturaDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ?");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra!");
            }

            else if (nota >= 7.0)
            {
                Console.WriteLine("aprovado!");
            }

            else if (nota >= 5.0)
            {
                Console.WriteLine("recuperação");
            }

            else { Console.WriteLine("te vejo na proxima..."); }


            Console.WriteLine("final!!");









        }
    }



}


