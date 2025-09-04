using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Class1 ma;
            ma = new Class1();


            Console.WriteLine("Digite a aresta:");
            ma.setA(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite :");
            ma.setB(int.Parse(Console.ReadLine()));
            ma.calcularAB();
            Console.WriteLine("{0} é sua área", ma.getMaior());











        }
    }
}
