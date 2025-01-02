using System.Runtime;

int resultado, numero;
do
{
    Console.WriteLine("escreve um numero pra fazer a tabuada: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        break;
    }
}
while (true);

for (int i = 0; i <= 10; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} X {i} = {resultado}");
};
Console.ReadKey();