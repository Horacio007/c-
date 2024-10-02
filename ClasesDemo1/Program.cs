using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClasesDemo1
{
    // classs nombre de clase
    // {
    // }

    public class Program
    {
        static void Main(string[] args)
        {
            //Rectangulo rectangulo = new Rectangulo(23,50);
            //Rectangulo rectangulo2 = new Rectangulo();

            //double resultadoArea = rectangulo.CalcularArea();
            //double resultadoPerimetro = rectangulo.CalcularPerimetro();
            //double resultadoPerimetoEstatico = Rectangulo.CalcularPerimetoEstatico(10, 10);

            //(var baseRect, var alturaRec) = rectangulo;

            //Console.WriteLine(baseRect);
            //Console.WriteLine(alturaRec);

            //Console.WriteLine(resultadoPerimetoEstatico);

            Circulo circulo1 = new Circulo(30);
            Circulo circulo2 = new Circulo(40);
            Circulo circulo3 = new Circulo(50);

            WriteLine("sdasdasd");

            var objetoAnonimo = new
            {
                area = 3, campo2 = 5
            };

            Console.WriteLine(objetoAnonimo.area);

            Console.WriteLine(Circulo.numeroDeCirculos);
            
                
            Console.ReadLine();

        }
    }
}
