using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariavesEConstantes
    {
        public static void Executar()
        {
            // Area da circuferencia 
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // pi = 3.1415


            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            //tipos internos 

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade" + idade);

            sbyte SaldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols" + SaldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario" + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populaçãoBrasileira = 207_600_000;
            Console.WriteLine("população brasileira" + populaçãoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long" + menorValorLong);

            ulong populaçaoMundial = 7_600_000_000;
            Console.WriteLine("Populaçao mundial" + populaçaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço computador" + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000_00;
            Console.WriteLine("valor apple" + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("distancia entre estrelas" + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("letra" + letra);

            string texto = " É nois que avoa!";
            Console.WriteLine(texto);




             
        }
    }
}