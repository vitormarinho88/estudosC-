﻿using PROJETOCSHARP;
using PROJETOCSHARP.API;
using System;
using System.IO;

namespace PROJETOCSHAP.API
{
    class ExemploDirectoryInfo
    {

        public static void Executar()
        {
            var dirProjeto = @"~/source/repos/estudoC-/PROJETOCSHARP".ParseHome();

            var dirInfor = new DirectoryInfo(dirProjeto);

            if (!dirInfor.Exists)
            {
                dirInfor.Create();

            }

            Console.WriteLine("==Arquivos ==========");
            var arquivos = dirInfor.GetFiles();
            foreach (var arquivo in arquivos)
            {

                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n== Diretorios =======");
            var pastas = dirInfor.GetDirectories();
            foreach (var pasta in pastas)
            {

                Console.WriteLine(pasta);
            }


            Console.WriteLine(dirInfor.CreationTime);
            Console.WriteLine(dirInfor.FullName);
            Console.WriteLine(dirInfor.Root);
            Console.WriteLine(dirInfor.Parent.Parent);
        }




    }
}

