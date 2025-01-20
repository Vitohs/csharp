using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Interface_Exercicio
{
    internal interface iSalvar
    {
        abstract void Salvar();
        void compactar()
        {
            Console.WriteLine("Compactando arquivo...");
        }
    }
}
