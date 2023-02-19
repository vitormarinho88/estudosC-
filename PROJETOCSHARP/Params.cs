using System;
using System.Security.Cryptography.X509Certificates;

class Params
{
    public static void Recepcionar(params string[] pessoas)
    {

        foreach (var pessoa in pessoas)
        {

            Console.WriteLine("Ola {0}", pessoa);


        }
    }

        public static void Executar () {
            
            Recepcionar("João Estrela", "zé", "Riquelme");



        }

    


}    