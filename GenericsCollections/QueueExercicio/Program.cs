using System;
using System.Collections.Generic;
using QueueExercicio;
var pedido = new Queue<Pedido>();
pedido.Enqueue(new Pedido(1, 10.00));
pedido.Enqueue(new Pedido(2, 20.00));
pedido.Enqueue(new Pedido(3, 30.00));
pedido.Enqueue(new Pedido(4, 82.00));
pedido.Enqueue(new Pedido(5, 22.22));
//exibindo numero de pedidos
Console.WriteLine($"Numero de pedidos na fila {pedido.Count}");
//localizando pedido usando linq
var pedidoLocalizado = pedido.FirstOrDefault(p => p.Numero == 3);

if (pedidoLocalizado == null)
    Console.WriteLine("Pedido não localizado");
else
    Console.WriteLine($"Pedido numero {pedidoLocalizado.Numero} localizado\n");

//processando pedido
while (pedido.Count > 0)
{
    var pedidoAtual = pedido.Dequeue();
    Console.WriteLine($"Pedido numero {pedidoAtual.Numero} no valor de {pedidoAtual.Valor} processado");
}
Console.ReadKey();
