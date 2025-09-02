using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex9
{
    internal class Maior2
    {


        private int a;
        private int b;
        private int maior;
        public void setA(int a)
        {
            this.a = a;
        }

        public int getA(int a)
        {
            return this.a;
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public int getB()
        {
            return this.b;
        }

        public int getMaior()
        {
            return this.maior;
        }
        public void calcularAB()
        {
            if (this.a > this.b)
            {
                this.maior = this.a;
            }
            
            else if (this.a < this.b)
            {
                this.maior = this.b;
            }

            else
            {
                Console.WriteLine("Sao iguais");
            }

        }
}
