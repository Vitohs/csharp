ProcessaObjeto("João", 1.80m);

Console.ReadKey();
void ProcessaObjeto(string nome, decimal altura)
{
    object obj = new { Nome = nome };
    object obj2 = new { Altura = altura };
    Type type = obj.GetType();
    Type type2 = obj2.GetType();
    Console.WriteLine($"Tipo de obj: {type}, Tipo de obj2: {type2}");
}
