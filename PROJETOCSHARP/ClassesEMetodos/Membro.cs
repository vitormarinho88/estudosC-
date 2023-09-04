using System;



namespace PROJETOCSHAP.ClassesEMetodos
{


    class Membro
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Vitor Marinho";
            sicrano.idade = 25;

            // Console.WriteLine($" {sicrano.Nome} tem {sicrano.idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Vitor Marinho";
            fulano.idade = 25;

            var apresentaçaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentaçaoDoFulano.Length);
            Console.WriteLine(apresentaçaoDoFulano);







        }

    }


}



