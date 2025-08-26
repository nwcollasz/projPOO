using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex3
{
    internal class Quadrado
    {

        private int d;
        private int sqr;

        public void setDiagonal(int d)
        {
            this.d = d;
        }

        public int getDiagonaç(int d)
        {
            return this.d;
        }

        public int getArea()
        {
            return this.sqr;
        }

        public void calcularArea()
        {
            this.sqr = (this.d * this.d) / 2;
        }



    }
}
