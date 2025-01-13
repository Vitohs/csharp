Console.WriteLine("Nao lembrei de voce nem um pouco, nao pensei no seu rosto");
string[] nomes = { };
double[] notas = { };
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Insira o nome");
    string nome = Console.ReadLine();
    Console.WriteLine($"Insira a nota do {nome}");
    double nota = double.Parse(Console.ReadLine());
    //alterando o tamanho do array
    Array.Resize(ref nomes, nomes.Length + 1);
    Array.Resize(ref notas, notas.Length + 1);
    nomes[i] = nome;
    notas[i] = nota;
    Console.Clear(); //limpando a tela
}
var media = notas.Average();//com o array ja cheio, estou tirando a media geral dos alunos
Console.WriteLine("Deseja exibir o nome de todos os alunos ?");
var resposta = Console.ReadLine();
if (resposta == "sim" || resposta == "Sim")
{
    int j = 0;
    while ( j < nomes.Length)
    {
        if (notas[j] >= 6)
        {
            Console.WriteLine($"Nome {nomes[j]}, nota: {notas[j]}, aprovado.");
        }
        else
        {
            Console.WriteLine($"Nome {nomes[j]}, nota: {notas[j]}, reprovado.");
        }
        j++;
    }
}
else
{
    Console.WriteLine("F.F.M");
}
Console.WriteLine($"A media de nota dos alunos é de: {media}");
Console.ReadKey();