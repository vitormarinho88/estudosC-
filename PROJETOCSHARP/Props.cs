using System;
using System.Security.Cryptography;

public class CarroOpcional
{
	double desconto = 0.1;

	string nome;
	public string Nome
	{
		get
		{
			return "Opcional:" + nome;

		}
		set
		{
			nome = value;
		}


	}


	// Propriedade autoimplementada
	public double Preço { get; set; }

	// Somente leitura
	public double PreçoComDesconto
	{
		get => Preço - (desconto * Preço); //Lambda 
	    //get {
		//     return preço - (desconto * preço);
	    // }


	}

	public CarroOpcional() { 

	


	}


	public CarroOpcional(string nome, double preço)
	{
		Nome = nome;
		Preço = preço;
	}



}


class Props {

	public static void Executar()
	{
		var op1 = new CarroOpcional("Ar condicionado", 3499.9);
		Console.WriteLine(op1.PreçoComDesconto);

		// op1.PreçoComDesconto = 3000;


		var op2 = new CarroOpcional();
		op2.Nome = "Direção Eletrica";
		op2.Preço = 2349.9;


		Console.WriteLine(op1.Nome);
		Console.WriteLine(op1.Preço);

		Console.WriteLine(op2.Nome);
		Console.WriteLine(op2.Preço);
		Console.WriteLine(op2.PreçoComDesconto);
	
	}


}  
      




	