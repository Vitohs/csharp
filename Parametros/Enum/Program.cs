using Enum;
Console.WriteLine("ENUM");
//usando um cast para poder forçar o Enum a liberar o valor
int dia = (int)DiasDaSemana.Segunda;
Console.WriteLine(dia + "\n");

Console.WriteLine($"{Categorias.Caneco} - {(int)Categorias.Caneco}");
Console.WriteLine($"{Categorias.Ak} - {(int)Categorias.Ak}");
Console.WriteLine($"{Categorias.ArBaby} - {(int)Categorias.ArBaby}");
Console.WriteLine($"{Categorias.Bazuca} - {(int)Categorias.Bazuca}");
Console.WriteLine($"{Categorias.Doze} - {(int)Categorias.Doze}");

Console.WriteLine("\nSelecione a categoria digitando seu valor");
var cat = Convert.ToInt32(Console.ReadLine());
var selecionado = (Categorias)cat;

Console.WriteLine($"Voce escolheu a categoria: {selecionado}");

Console.ReadKey();