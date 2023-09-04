using System;
using System.Collections.Generic;

namespace PROJETOCSHAP.ClassesEMetodos
{



    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.somar(2, 2));

        }

    }

    public class CalculadoraEstatica
    {
        //Metodo de Classe ou Metodo estatico 
        public static int Multiplicar(int a, int b)
        {

            return a * b;
        }

        //Metodo de instancia
        public int somar(int a, int b)
        {

            return a + b;
        }


    }
}









