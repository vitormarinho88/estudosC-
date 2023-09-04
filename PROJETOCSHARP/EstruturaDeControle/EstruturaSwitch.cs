using System;
using System.Diagnostics;


namespace PROJETOCSHAP.EstruturaDeControle
{
    class EstruturaSwitch
    {

        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento de 1 a 5");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("pessimo");
                    break;

                case 1:
                case 2:
                    Console.WriteLine("ruim");
                    break;

                case 3:
                    Console.WriteLine("Regular");
                    break;

                case 4:
                    Console.WriteLine();
                    break;

                case 5:
                    Console.WriteLine("otimo");
                    break;
                default:
                    Console.WriteLine("nota invalida");
                    break;

                    Console.WriteLine("Obrigado por responder");













            }
        }
    }



}




	
