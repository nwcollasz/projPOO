using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior ma;
            ma = new Maior();

            
            Console.WriteLine("Digite um valor:");
            ma.setA(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite outro valor:");
            ma.setB(int.Parse(Console.ReadLine()));
            ma.calcularAB();
            Console.WriteLine("{0} é o maior valor", ma.getMaior());










        }
    }
}
