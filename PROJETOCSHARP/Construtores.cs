using System;

class Carro
{
    public string Modelo;
    public string Fabricante;
    public int Ano;

    public Carro(string modelo, string fabricante, int ano)
    {
        Modelo = modelo;
        Fabricante = fabricante;
        Ano = ano;

    }

    public Carro()
    {

    }
              

}

class Construtores
{
    public static void Executar()
    {
        var carro1 = new Carro();
        carro1.Fabricante = "Ferrari";
        carro1.Modelo = "488";
        carro1.Ano = 2023;
        Console.WriteLine(
            $"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

        var carro2 = new Carro("ka", "Ford", 2018);
        Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

        var carro3 = new Carro()
        {
            Fabricante = "fiat",
            Modelo = "Uno",
            Ano = 2019
        };

    }




}   

