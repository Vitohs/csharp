// projeto do curso
//criando um objeto
//using System;
using Projetocar;
Carro chervolet = new Carro("sedan", "Chervolet", "Onix", 2019, 110);

Carro ford = new Carro("SUV", "ford", "EcosSport", 1998, 120);

Carro Azera = new("Sani", "Ferrari");
int x = 400;

//Console.WriteLine("OIII");
//Console.WriteLine(ford.AumentarPotencia(ref x));

int carrin = chervolet.AumentarVelocidadePotencia(110, out double velocidade);
//Console.WriteLine("Nome do carro: " + chervolet.modelo);
//Console.WriteLine("Nova potencia: " + carrin);
//Console.WriteLine("Nova velocidade: " + velocidade);

//ford.ExibirInfo();
Console.WriteLine($"IPVA DOS CARRO: {Carro.ipva}");
//Carro.ObterIPVA();
//Console.WriteLine("\n Valor do IPVA: " + Carro.ipva);
Console.WriteLine("Escolha uma cor\n");
Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");
int valor = Convert.ToInt32(Console.ReadLine());
chervolet.cor = valor;
chervolet.ExibirInfo();
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
    private int _ano;
    public int ano 
    {
        get { return _ano; }
        set
        {
            if (value < 2000)
            {
                _ano = 2000;
            }
            else if (value > 2024)
            {
                _ano = 2024;
            }
            else
            {
                _ano = value;
            }
        }
    }
    public int potencia;
    public int cor;
    public static double ipva = 0.04;

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        return potencia + 3;
    }

    public int AumentarPotencia(ref int y)
    {
        y += 5;
        return y;
    }

    public int AumentarVelocidadePotencia(int potencia, out double velocidade)
    {
        potencia = this.potencia + 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    //função que não retorna nada
    public void Acelerar(string? m)
    {
        m = this.montadora;
        Console.WriteLine("Acelerando meu " + m);
    }
    public void ExibirInfo()
    {
        Console.WriteLine($"Modelo do carro: {this.modelo},\n sua montadora: {this.montadora},\n marca: {this.marca},\n potencia do carro: {this.potencia},\n ano: {this.ano},\n Cor do Carro: {(Cores)this.cor}");
    }

    public static void ObterIPVA()
    {
        ipva = 0.04;
    }
}