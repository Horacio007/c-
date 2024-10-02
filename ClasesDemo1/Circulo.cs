using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo1
{
    public class Circulo
    {
        private double _radio;

        public static int numeroDeCirculos;

        public double Radio
        {
            get
            {
                return _radio;
            }
            set
            {
                _radio = value;
            }
        }

        public Circulo(int radioInicial) 
        {
            _radio = radioInicial;
            numeroDeCirculos++;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(_radio, 2);
        }

    }
}
