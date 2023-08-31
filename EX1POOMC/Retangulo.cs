using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1POOMC
{
    internal class Retangulo
    {
        private double baseRetangulo;

        private double alturaRetangulo;



        public Retangulo(double baseRetangulo, double alturaRetangulo)

        {

            this.baseRetangulo = baseRetangulo;

            this.alturaRetangulo = alturaRetangulo;

        }



        public double CalcularArea()

        {

            return baseRetangulo *alturaRetangulo;

        }
    }
}
