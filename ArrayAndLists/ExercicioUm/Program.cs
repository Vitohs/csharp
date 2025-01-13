string[] frutas = {"Maça", "Banana", "Laranja", "Uva", "Manga", "Pera", "Abacate", "Mamao", "Pessego", "Amora"};
int i = 0;

Console.WriteLine($"Goste de {frutas[1]} e de {frutas[8]}");
frutas[2] = "Kiwi";
frutas[9] = "Caqui";
Array.Reverse(frutas);
foreach (var fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta} - indice: {i}");
    i++;
}
