float[,] Notas = new float[5, 2];
//grupo 0
Notas[0, 0] = 7.5f;
Notas[1, 0] = 10;
Notas[2, 0] = 6.5f;
Notas[3, 0] = 2.2f;
Notas[4, 0] = 4.7f;
//grupo 1
Notas[0,1] = 4.5f;
Notas[1,1] = 2.7f;
Notas[2,1] = 8.8f;
Notas[3,1] = 9.9f;
Notas[4,1] = 0.5f;
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Notas do grupo {i}");
    for (int k = 0; k < 5; k++)
    {
        Console.WriteLine(Notas[k, i]);
    }
}
Console.ReadKey();