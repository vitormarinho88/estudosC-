using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace PROJETOCSHAP.Coleções
{
    class ColecQueue
    {

        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Vitor");
            fila.Enqueue("Vitim");
            fila.Enqueue("Riquelme");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);

            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);


            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("item"));


        }












    }


}



