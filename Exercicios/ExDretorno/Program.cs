Carro chervolet = new Carro("sedan", "Chervolet", "Onix", 2019, 110);

Carro ford = new Carro("SUV", "ford", "EcosSport", 2018, 120);

Carro Azera = new("Sani", "Ferrari");

Console.WriteLine($"A Velocidade do carro {Azera.modelo} é de: " + Azera.VelocidadeMaxima(300));

//Console.WriteLine("#Carro Ford\n#");
//Console.WriteLine("Modelo: " + ford.modelo);
//Console.WriteLine("Montadora:" + ford.montadora);
//Console.WriteLine("Marca: " + ford.marca);
//Console.WriteLine("Ano: " + ford.ano);
//Console.WriteLine("Potencia: " + ford.potencia);
//ford.Acelerar(ford.montadora);

//Console.WriteLine("");

//Console.WriteLine("#Carro da chervolet#");
//Console.WriteLine("Modelo: " + chervolet.modelo);
//Console.WriteLine("Montadora: " + chervolet.montadora);
//Console.WriteLine("Marca: " + chervolet.marca);
//Console.WriteLine("Ano: " + chervolet.ano);
//Console.WriteLine("Potencia: " + chervolet.potencia);
//chervolet.Acelerar(chervolet.montadora);

Console.ReadKey();

public class Carro
{
    public Carro(string model, string mar)
    {
        modelo = model;
        marca = mar;
    }

    //construct
    public Carro(string mo, string ma, string mar, int ano, int po)
    {
        modelo = mo;
        montadora = ma;
        marca = mar;
        this.ano = ano;
        potencia = po;
    }

    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    //função que não retorna nada
    public void Acelerar(string? m)
    {
        m = this.montadora;
        Console.WriteLine("Acelerando meu " + m);
    }
}
