using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex7
{
    internal class Dolar
    {
        private double dolar;
        private double real;

        public void setDolar(double dolar)
        {
            this.dolar = dolar;
        }

        public double getDolar(double dolar)
        {
            return this.dolar;
        }

        public void setKm(double real)
        {
            this.real = real;
        }



        public double getReal()
        {
            return this.real;
        }

        public void calcularReal()
        {
            this.real = this.dolar * 5.44;
        }


























    }
}
