using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposValorTiposReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //int valor1 = 50;
            //int valor2 = valor1;

            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);  

            //Circulo circ1 = new Circulo();
            //circ1.radio = 50;

            //Circulo circ2 = circ1;

            //Console.WriteLine(circ1.radio);
            //Console.WriteLine(circ2.radio);

            //circ1.radio = 20;

            //Console.WriteLine(circ1.radio);
            //Console.WriteLine(circ2.radio);

            //int numero1 = 0;
            //AgregarUno(numero1);

            //Console.WriteLine(numero1);

            //Circulo circulo = new Circulo();
            //circulo.radio = 10;
            //AgregarUno(circulo);

            //Console.WriteLine(circulo.radio);

            //Circulo circulo = null;

            //if (circulo != null)
            //{
            //    circulo = new Circulo();
            //    circulo.radio = 50;
            //}

            //Console.WriteLine(circulo?.radio);

            //int? i = null;
            ////i = 10;

            //int? j = 0;
            //j = i;

            //if (!i.HasValue)
            //{
            //    i = 10;
            //}
            //else
            //{
            //    Console.WriteLine(i.Value);
            //}

            //int variable = 0;
            //AgregarUno(ref variable);

            //int numero2;
            //AgregarUno(out numero2);

            //int.TryParse("756", out int pruebaConversion1);
            //Console.WriteLine(pruebaConversion1);

            //Console.WriteLine(numero2);

            //object entero = 13;
            //object cadena = "Hola Mundo!!!";
            //object circulo = new Circulo();

            //int valor = 50;
            //object objeto = valor;

            //int otroValor = (int)objeto;

            //Console.WriteLine(otroValor);

            int valor = 50;
            //object objeto = "Hola";
            object objeto = 42;

            if (objeto is string)
            {
                Console.WriteLine("es un string");
            }
            else if (objeto is Circulo)
            {
                Circulo circulo = (Circulo)objeto;  
                Console.WriteLine(circulo.radio);    
            }

            Console.WriteLine(objeto);

            string valor2 = objeto as string;

            if (valor2 != null)
            {
                Console.WriteLine(valor2);
            }


            Console.ReadLine();

        }

        //public static void AgregarUno(ref int param1)
        //{
        //    param1++;
        //}

        public static void AgregarUno(out int param1)
        {
            param1 = 0; 
            param1++;
        }

        public static void AgregarUno(Circulo circulo)
        {
            circulo.radio++;
        }
    }
}
