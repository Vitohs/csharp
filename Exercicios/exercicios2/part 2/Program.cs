//Context: 5 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
//a concatenação e também a interpolação de strings

Console.WriteLine("Digite uma letra ai  ");
string letra1 = Console.ReadLine();

Console.WriteLine("Digite mais uma  ");
string letra2 = Console.ReadLine();

Console.WriteLine("Mais uma  ");
string letra3 = Console.ReadLine();

Console.WriteLine("");

Console.WriteLine($"veja as letras que tu digitou {letra3}, {letra2}, {letra1} \n");

//Contexto: 7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
//exibindo o resultado
double x;
double y;
Console.WriteLine("Digite um numero ai: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite mais um numero ai: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A soma de {x} e {y} dá {x + y}");

Console.WriteLine($"A subtração de {x} e {y} dá {x - y}");

Console.WriteLine($"A multiplicação de {x} e {y} dá {x * y}");

Console.WriteLine($"A Divisçao de {x} e {y} dá {x/y}");

Console.ReadKey();




