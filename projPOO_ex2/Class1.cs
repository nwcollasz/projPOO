using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex2
{
    internal class Quadrado
    {
        private int l;
        private int sqr;

        public void setAresta(int l)
        {
            this.l = l;
        }

        public int getAresta(int l)
        {
            return this.l;
        }

        public int getArea()
        {
            return this.sqr;
        }

        public void calcularArea()
        {
            this.sqr = this.l * this.l;
        }












    }
}
