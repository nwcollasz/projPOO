using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dolar dol;
            dol = new Dolar();

            Console.WriteLine("Digite o valor em dólares: ");
            dol.setDolar(double.Parse(Console.ReadLine()));
            dol.calcularReal();
            Console.WriteLine("Valor em reais {0}.", dol.getReal());











        }
    }
}
