using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo1
{
    class Rectangulo
    {
        double _base;
        double _altura;
        string _color;

        public Rectangulo()
        {
            _base = 0;
            _altura = 0;
            _color = "red";
        }

        public Rectangulo(double baseR, double altura)
        {
            _base = baseR;  
            _altura = altura;
        }

        public void Deconstruct(out double baseRec, out double alturaRec)
        {
            baseRec = _base;
            alturaRec = _altura;   
        }

        public double CalcularArea()
        {
            return _base * _altura;
        }

        public double CalcularPerimetro()
        {
            return (2 * _altura) + (2 * _base);
        }

        public static double CalcularPerimetoEstatico(double altura, double _base)
        {
            return (2 * altura) + (2 * _base);
        }
    }
}
