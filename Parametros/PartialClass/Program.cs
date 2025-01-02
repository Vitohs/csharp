using PartialClass;

Console.WriteLine("PARTIAL CLASS");
MinhaPartialClass minhaPartialClass = new();

Console.WriteLine("Data de nascimento 07/03/2006");

var idade = minhaPartialClass.CalcularIdade(new DateTime(2006, 3, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");
var data = DateTime.Now;
var data2 = new DateTime(2006, 01, 03);
var diferencas = minhaPartialClass.DiferencaEntreDatas(data, data2);

Console.WriteLine($"{Math.Round(diferencas.TotalDays / 365)}");
Console.ReadKey();