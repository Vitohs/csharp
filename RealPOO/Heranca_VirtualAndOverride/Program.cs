var gato = new Gato();
gato.Nome = "Felix";
gato.Exibir();

var cachorro = new Cachorro();
cachorro.Nome = "Rex";
cachorro.Exibir();

Console.ReadKey();
class Animal
{
    public string? Nome { get; set; }
    //usando a palavra virtual, eu permito que a classe filha sobrescreva o método ou o extenda
    public virtual void Exibir()
    {
        Console.WriteLine("Meu nome é: " + Nome);
    }
}
class Gato : Animal
{
    public override void Exibir()
    {
        Console.WriteLine("Eu sou um gato e meu nome é: " + Nome);
    }
}
class Cachorro : Animal
{
  //cachorro vai usar o metodo da classe pai
}