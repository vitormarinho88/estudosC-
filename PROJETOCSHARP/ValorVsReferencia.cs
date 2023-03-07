using System;

public class Dependente { 

    public string Nome;
    public int Idade;

}

class ValorVsReferencia
{
    public static void Executar()
    {
        int numero = 3;
        int copiaNumero = numero;
        Console.WriteLine($" {numero} {copiaNumero}");

        numero++;
        Console.WriteLine($"{numero} {copiaNumero}");

        Dependente dep = new Dependente
        {
            Nome = "VITOR",
            Idade = 25

        };

        Dependente copiaDep = dep;

        Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
        Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

        copiaDep.Nome = "RIQUELME";
        dep.Idade = 26;


        Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
        Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");   
    
    
    
    }



}











