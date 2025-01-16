using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Tips
{
    internal class Altura : Base, InterfaceAltura
    {
        public void MetodoAltura()
        {
            Console.WriteLine("Método Altura");
        }
    }

}
