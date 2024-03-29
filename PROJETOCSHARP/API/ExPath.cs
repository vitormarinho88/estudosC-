﻿using PROJETOCSHARP;
using PROJETOCSHARP.API;
using System;
using System.IO;

namespace PROJETOCSHAP.API
{
    class ExemploPath
    {

        public static void Executar()
        {

            var arquivo = @"~/exemplo_path_arquivos.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))
            {

                using (StreamWriter sw = File.CreateText(arquivo))
                {

                    sw.WriteLine("UM NOVO ARQUIVO CRIADO!");
                }

            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);

            }

            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));
        }








    }
}

