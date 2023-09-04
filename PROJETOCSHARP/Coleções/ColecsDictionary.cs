using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETOCSHAP.Coleções
{
    class ColecsDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2019, "O irlandes");
            filmes.Add(2023, "Jhon Wick");
            filmes.Add(2017, "Forja Hernan");
            filmes.Add(2018, "We Are Lost");

            if (filmes.ContainsKey(2023))
            {
                Console.WriteLine("2023: " + filmes[2023]);
                Console.WriteLine("2023: " + filmes.GetValueOrDefault(2023));


            }

            Console.WriteLine(filmes.ContainsValue("Amsnésia"));
            Console.WriteLine($"Removeu? {filmes.Remove(2023)}");

            filmes.TryGetValue(2018, out string filmes2018);
            Console.WriteLine($"Filme  {filmes2018}!");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);

            }

            foreach (var valor in filmes.Values)
            {

                Console.WriteLine(valor);

            }


            foreach (KeyValuePair<int, string> filme in filmes)
            {

                Console.WriteLine($"{filme.Value} é de {filme.Key}.");


            }


            foreach (var filme in filmes)
            {

                Console.WriteLine($"{filme.Value} é de {filme.Key}.");

            }



        }



    }



}
