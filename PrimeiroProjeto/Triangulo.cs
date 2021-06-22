using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Triangulo
    {
        public double ladoA;
        public double ladoB;
        public double ladoC;

        public double Area()
        {
            double p = (ladoA + ladoB + ladoC) / 2.0;
            double raiz = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
            return raiz;
        }

    }
}
