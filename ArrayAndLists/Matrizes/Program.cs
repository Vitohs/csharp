Console.WriteLine("Matrixes (array multidimensional)");
int[,] matriz = 
{
    { 0,3 },
    { 2,5 }
};
//representação grafica
//          Coluna 0       Coluna 1
// linha 0     0              3

// linha 1     2              5
//acessando elementos com laço for
//GetLength(0) retorna o tamanho da primeira dimensão (linha)
for (int i = 0; i < matriz.GetLength(0); i++)
{
    //GetLength(1) retorna o tamanho da segunda dimensão (coluna)
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write($"{matriz[i, j]}");
    }
}
Console.WriteLine(" ");
//acessando elementos com foreach
foreach (var n in matriz)
{
    Console.Write(n);
}
Console.ReadKey();