using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangulo tri;
            tri = new Triangulo();

            Console.WriteLine("Digite o valor da base do triângulo:");
            tri.setBase(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor da altura do triângulo:");
            tri.setAltura(int.Parse(Console.ReadLine()));

            tri.calcularArea();

            Console.WriteLine("A área desse triângulo é {0}.", tri.getArea());



        }
    }
}
