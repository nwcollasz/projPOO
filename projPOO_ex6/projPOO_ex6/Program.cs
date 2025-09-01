using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Milhas mil;
            mil = new Milhas();

            Console.WriteLine("Digite o valor em quilometros: ");
            mil.setNmilha(double.Parse(Console.ReadLine()));
            mil.calcularKm();
            Console.WriteLine("Milhas Náuticas{0}.", mil.getKm());















        }
    }
}
