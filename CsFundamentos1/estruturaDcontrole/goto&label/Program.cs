
int i = 0;
//certo, começo declarando uma label, é quase que uma classe
nobru:

Console.WriteLine($"oie, a variavel ta com o valor {i}");
//aqui é basicamente i= i + 1
i++;
//ja sabe ne paizao, se entrar, eu mando o goto,
//que basicamente vai acessar o codigo da label ate que o if seja falso
if (i <= 10)
{
    goto nobru;
}
//fim
Console.WriteLine("fim");

Console.ReadKey();