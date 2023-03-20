using System;
using System.Net.Http.Headers;

class ColecSet    {

	public static void Executar()
	{
		var livro = new Produto("Naruto", 69.0);

		var carrinho = new HashSet<Produto>();
		carrinho.Add(livro);

		var combo = new HashSet<Produto>
		{
			new Produto("Camisa", 159.0),
			new Produto("2 Temporada Naruto Shippuden", 85.0),
			new Produto("poster", 50)
		};


		carrinho.UnionWith(combo);
		Console.WriteLine(carrinho.Count);
	    //carrinho.RemoveAt(3);
	
	    
		foreach (var item in carrinho)    {

			// Console.WriteLine(carrinho.indexOf (item));

			Console.WriteLine($" {item.Nome} {item.Preço}");
		
		}

		Console.WriteLine(carrinho.Count);
		carrinho.Add(livro);
		Console.WriteLine(carrinho.Count);
	    //Console.WriteLine (carrinho.LastIndexOf(livro));
	
	}



}

	
