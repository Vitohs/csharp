﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorDeAcesso;
internal struct MinhaStruct
{
    int MeuCampo;
    string? MinhaPropriedade { get; set; }
    void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}
