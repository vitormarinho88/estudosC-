using System;

class EstruturaIF
{
    public static void Executar()
    {
        bool BomComportamento = false;
        string entrada;

        Console.WriteLine("Digite a nota do aluno:");
        entrada = Console.ReadLine();
        Double.TryParse(entrada, out double nota);

        Console.WriteLine("possui bom comportamento (S/N):");
        entrada = Console.ReadLine();

        //f (entrada == "S" || entrada == "s")
        // BomComportamento = true;

        // bomcomportamento = entrada == "S" || entrada == "s";
        BomComportamento = entrada.ToLower() == "s";


        if (nota >= 9.0 && BomComportamento)
        {
          Console.WriteLine("quadro de honra!");



        }



    }


   




        

}

