using System;
using System.Collections.Generic;
using Generic_Exercicio;
GenericClass<int> generic = new GenericClass<int>();
generic.Add(1);
generic.Add(2);
Console.WriteLine(generic[0]);
Console.ReadKey();