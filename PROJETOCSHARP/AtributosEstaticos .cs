using System;

public class produto
{
	public string Nome;
	public double Preço;
	public static double Desconto = 01;

    public produto (string nome, double preço, double desconto) {

		Nome = nome;
		Preço = preço;
		Desconto = desconto;

    }

    public produto () { 
	

	}       

	public double CalcularDesconto () {
		return Preço - Preço * Desconto;
		
	}

}

class AtributosEstaticos
{
	public static void Executar()
	{
		var produto1 = new produto("Caneta", 3.2, 0.1);

		var produto2 = new produto()
		{
			Nome = "Borracha",
			Preço = 5.3
		};


		produto.Desconto = 0.5;

		Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
		Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

		produto.Desconto = 0.02;

		Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
		Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());




	}


}