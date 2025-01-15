using System;
using System.Collections.Generic;
using Heranca_Exercicio1;
//conta corrente
Banco corrente = new();
corrente.ExibirSaldo();
corrente.Depositar(100);
corrente.Sacar(100);
corrente.ExibirSaldo();
corrente.Sacar(100);
corrente.ExibirSaldo();
//conta poupanca
ContaPoupanca poupanca = new();
poupanca.ExibirSaldo();
poupanca.Depositar(100);
poupanca.ExibirSaldo();
Console.ReadKey();