Console.WriteLine("CONSTRUTOR ESTATICO");

Pessoa p1 = new Pessoa(18, "Victor");

Console.WriteLine($"\n Nome: {p1.nome},\n idade: {p1.idade},\n idade minima: {Pessoa.idademinima}");

Console.ReadKey();