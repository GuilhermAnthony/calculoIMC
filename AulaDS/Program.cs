using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();

            //p1.cadastrar();
            //p1.mostrarDados();

            p1.calculoImc();
            p1.mostrarResultado();

            Console.ReadKey();
        }
    }
}
