using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex6
{
    internal class Milhas
    {
        private double milha;
        private double km;

        public void setNmilha(double milha)
        {
            this.milha = milha;
        }

        public double getNmilha(double milha)
        {
            return this.milha;
        }

        public void setKm(double km)
        {
            this.km = km;
        }



        public double getKm()
        {
            return this.km;
        }

        public void calcularKm()
        {
            this.km = this.milha * 1.852;
        }















    }
}
