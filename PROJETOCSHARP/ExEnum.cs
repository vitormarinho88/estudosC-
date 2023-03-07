using System;

public enum Genero {Açao , Aventura, Terror, Animaçao, Comedia};

public class Filme
{
    public string Titulo;
    public Genero GeneroDoFilme;
}

class ExEnum
{
    public static void Executar ()
    {
        int id = (int)Genero.Animaçao;
        Console.WriteLine(id);

        var filmeParaFamilia = new Filme();
        filmeParaFamilia.Titulo = "HEREDITARIO 20";
        filmeParaFamilia.GeneroDoFilme = Genero.Terror;

        Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
    }


}