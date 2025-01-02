Console.WriteLine("PROPRIEDADES\n");

Produto p1 = new();
p1.Nome = "Notebook";
p1.Preco = 3.99;
p1.EstoqueMinimo = 150;

p1.Exibir();

Console.ReadKey();
public class Produto
{
    private string? nome;
    public string? Nome
    {
        get { return nome?.ToUpper(); }
        set { nome = value; }
    }
    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
            {
                preco = 5.00;
            }
            else
            {
                preco = value;
            }
        }
    }
    private double desconto = 0.05;
    public double Desconto 
    {
        get { return desconto; }
    }
    public double PrecoFinal
    {
        get { return preco - (Preco * Desconto); }
    }
    private int minimo;
    public int EstoqueMinimo 
    { 
        set { minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome} \nPreço {Preco.ToString("c")} \nDesconto: {Desconto} \nPreço Final: {PrecoFinal.ToString("c")} \nEstoque: {minimo}");
    }
}