using System;

class Array
{

    public static void Executar() {
        string[] alunos = new string[5];
        alunos[0] = "RIQUELME";
        alunos[1] = "JOÃO ESTRELA";
        alunos[2] = "ZE BUNITIN";
        alunos[3] = "THLIO";
        alunos[4] = "TONACO";

        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);

        }

        double somatorio = 0;
        double[] notas = { 9.7, 4.8, 8.4, 6.8, 8.2 };

        foreach (var nota in notas) {
            somatorio += nota;


        }



        // for (int i = 0; i < notas.Length; i++) {  
        // somatorio += notas[1];                       exemplo foreach para acessar array

        //}


        double media = somatorio / notas.Length;
        Console.WriteLine(media);


        char[] letras = { 'A', 'R', 'R', 'A', 'Y' };
        String palavra = new string(letras);
        Console.WriteLine(palavra);
    
    } 







}