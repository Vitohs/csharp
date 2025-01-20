//composicao
using System;
using System.Collections.Generic;
using Composicao;
Peixe peixe = new Peixe();//nesse momento nadar e andar são instanciados
peixe.Nadar();

Homem homem = new Homem();
homem.Andar();

Macaco macaco = new Macaco();
macaco.Andar();
Console.ReadKey();