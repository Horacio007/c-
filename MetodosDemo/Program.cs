using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola mundo !!!");
            //BorrarConsola();

            //Console.WriteLine(2 + 5);


            //Console.WriteLine("hORACIO");

            //Saludar("Hola José como estas ????");

            int resultado = Sumar(10, 12);
            Console.WriteLine(resultado / 2);   

            Console.ReadLine();
        }

        // Tipo de dato a retornar + nombre del metodo + parametros
        static void BorrarConsola()
        {
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }

        static void Saludar(string nombre)
        {
            Console.WriteLine(nombre);
        }

        static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static void SaludarExpresion() => Console.WriteLine("Hola desde la expresion");

        static int SumarExpresion(int numero1, int numero2) => numero1 + numero2;
    }
}
