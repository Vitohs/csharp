﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca;

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public void View()
    {
        Console.WriteLine($"Nome: {Nome} - Email: {Email}");
    }
}
