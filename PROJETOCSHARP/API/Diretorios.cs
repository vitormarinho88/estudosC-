using PROJETOCSHARP;
using System;
using System.IO;


namespace PROJETOCSHARP.API
{
    class Diretorios
    {

        public static void Executar()
        {

            var novoDir = @"~/PROJETOCSHARP".ParseHome();
            var novoDirDestino = @"~/PastaPROJETOCSHARP".ParseHome();
            var dirProjeto = @"~/source/repos/estudoC-/PROJETOCSHARP".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);

            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));


            Console.WriteLine("== pastas ======");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {

                Console.WriteLine(pasta);
            }


            Console.WriteLine("\n\n== Arquivos ============");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }


            Console.WriteLine("\n\n===Raiz =============");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);

        }










    }
}