using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex11
{
    internal class Peso
    {

        private double p;
        private double a;
        private double relacao;
        public void setP(double p)
        {
            this.p = p;
        }

        public void setA(double a)
        {
            this.a = a;
        }

        public double getA()
        {
            return this.a;
        }

        public double getP()
        {
            return this.p;
        }

        public double getRel()
        {
            return this.relacao;
        }
        public void calcularRel()
        {
            this.relacao = this.p / (this.a * this.a);


            if (this.relacao < 20)
            {
                Console.WriteLine("Abaixo do peso:");

            }
            else if (this.relacao >= 25)
            {
                Console.WriteLine("Acima do peso:");
            }
             if (this.relacao >= 20 && this.relacao < 25)
            {
              Console.WriteLine("Peso ideal");
            }

        }


    }
}