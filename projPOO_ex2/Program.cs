using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Quadrado quad;
            quad = new Quadrado();

            Console.WriteLine("Digite o valor da aresta do quadrado:");
            quad.setAresta(int.Parse(Console.ReadLine()));
            quad.calcularArea();
            Console.WriteLine("Sua área é igual a {0}.", quad.getArea());












        }
    }
}
