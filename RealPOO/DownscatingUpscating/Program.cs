using System;
using System.Collections.Generic;
using DownscatingUpscating;
//Fazenndo uso de upcasting
//Forma circulo = new Circulo(10, 10); //upcasting
//segundo exemplo
Circulo circulo = new Circulo(10, 10);
Forma forma = circulo; //upcasting.. circulo decide ser Forma, veste o traje Forma forma
Console.WriteLine(forma == circulo);
forma.Desenhar();
//downcasting
Circulo c = (Circulo)forma; //downcasting.. forma decide ser Circulo, tira o traje Forma e veste e volta a ser instancia de Circulo naturalmente
c.PintarCirculo();
Console.WriteLine(c == forma);
Console.WriteLine(c == circulo);
Console.ReadKey();
//Logica de Upcasting e Downcasting
//Upcasting: Forma forma = circulo;

//    forma aponta para o mesmo objeto que circulo, mas agora está usando uma referência Forma.

//    Mesmo que forma seja uma referência Forma, o objeto ainda é um Circulo, então o método sobrescrito Desenhar de Circulo é chamado.

//    Downcasting: Circulo c = (Circulo)forma;

//    forma está sendo reinterpretada como uma referência Circulo.

//    Como forma realmente aponta para um Circulo, o downcasting é bem-sucedido e agora você pode chamar métodos específicos de Circulo como PintarCirculo.