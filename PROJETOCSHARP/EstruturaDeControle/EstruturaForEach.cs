using System;


namespace PROJETOCSHAP.EstruturaDeControle
{
    class EstruturaForEach
    {

        public static void Executar()
        {

            var palavra = "opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);


            }

            var alunos = new string[] { "joao", "ze", "maria" };

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);

            }







        }


    }


}


