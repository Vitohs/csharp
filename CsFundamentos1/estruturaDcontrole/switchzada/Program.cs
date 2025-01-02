Console.WriteLine("digite o valor do produto:");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("quantas parcelas:");
Console.WriteLine("1~ 4 vezes");
Console.WriteLine("2~ 6 vezes");
var num2 = Convert.ToInt32(Console.ReadLine());
    
int resultado;

switch (num2)
 {
    case 1:
        resultado = num1 / 4;
        Console.WriteLine($"certo cada parcela será de: {resultado}");
        break;

    case 2:
        resultado = num1 / 6;
        Console.WriteLine($"certo cada parcela será de: {resultado}");
        break;

    default:
        Console.WriteLine("ta certo isso ?");
        break;
}

