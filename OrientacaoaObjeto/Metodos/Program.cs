
var tw = new Imc();

tw.oii(90, 183);

Console.ReadKey();

class Imc()
{
    public void oii(int peso, int altura)
    {
        int pmc = peso / (altura * altura);
        Console.WriteLine($"Peso: {peso} altura: {altura}, IMC de: {pmc}");

    }
}
