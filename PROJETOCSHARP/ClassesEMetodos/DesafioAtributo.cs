using System;


namespace PROJETOCSHAP.ClassesEMetodos
{

    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            // Acessar variavel 'a' dentro do metodo Executar 
            // console.writeline (a);

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }



    }

}

