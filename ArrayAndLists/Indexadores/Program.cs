using System;
using System.Collections;
using System.Collections.Generic;
using Indexadores;
Console.WriteLine("INDEXADORES");

Times times = new();
times[0] = "Palmeiras";
times[1] = "São Paulo";
times[2] = "Corinthians";

var trikas = times[1];  

Console.WriteLine(trikas);

Console.ReadKey();