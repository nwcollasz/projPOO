using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso p = new Peso();

            Console.WriteLine("Digite seu peso:");
            p.setP(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite sua altura :");
            p.setA(double.Parse(Console.ReadLine()));
            p.calcularRel();
            Console.WriteLine(p.getRel());

        }
    }
}
