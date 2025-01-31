using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUndo;

internal class EditorTexto
{
    private Stack<char> undoStack = new Stack<char>();
    private string texto = "";

    public void DigitarChar(char c)
    {
        texto += c;
        undoStack.Push(c);
        Console.WriteLine($"Texto: {texto}");
    }
    public void Undo()//desfazer ultima alteração
    {
        if (undoStack.Count > 0)
        {
            char ultimoChar = undoStack.Pop();
            texto = texto.Substring(0,texto.Length - 1);
            Console.WriteLine($"Texto: {texto}");
        }
    }
    public void ExibirStack()
    {
        Console.WriteLine("Stack:");
        foreach (var item in undoStack)
        {
            Console.WriteLine(item);
        }
    }
}
