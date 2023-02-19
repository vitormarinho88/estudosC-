using System;


class Pessoa
{
   
    
    public string Nome;
    public int idade;

    public string Apresentar() {
    

        return string.Format
            ($" Olá! Me chamo {Nome} e tenho {idade} anos.");


    }


    public void ApresentarNoConsole() {

        Console.WriteLine(Apresentar());

    }


}