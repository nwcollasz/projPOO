using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    
	{


        private int a;
        private int b;
        private int area;
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
            return this.area;
        }
        public void calcularAB()
        {
            this.area = this.a * this.b;
            
            
            if (this.area > 100)
            {
                Console.WriteLine("Terreno grande:");
            }



        }









    }
        
    
}
