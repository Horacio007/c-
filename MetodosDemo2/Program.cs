using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDemo2
{
    class Program
    {
        static string nombre = "Pedro";
        static void Main(string[] args)
        {
            //var res = RegresarDatos();
            //Console.WriteLine(res.Item3);

            //int cociente = 0;
            //int residuo = 0;
            //(cociente, residuo) = Dividir(50, 25);
            //Console.WriteLine($"Cociente: {cociente} -> Residuo: {residuo}");

            //(int cociente, int residuo) data = Dividir(100, 25);

            //Console.WriteLine($"Cociente nueva forma {data.cociente} -> Residuo nueva forma {data.residuo}");


            //Saludar2();
            ////nombre = "Pascal";
            ////Saludar();

            //Multiplicar(2, 2);

            //Console.WriteLine(CalcularCuenta(100, 10, 3));
            //Console.WriteLine(CalcularCuenta(100, 10, 3,50));


            //EscribirText("Hola como tas");

            Console.WriteLine(CalcularCuentaConParametroOpcional(100, 10, 2, 45));

            Console.WriteLine(CalcularCuentaConParametroOpcional(100, 10, 2, iva:16));


            Console.ReadLine();
        }



        static void EscribirText(string texto)
        {
            Console.WriteLine(texto);
            Limpiar();
            void Limpiar()
            {
                Console.ReadLine();
                Console.Clear();
                Console.Beep();
            }
        }

        static double CalcularCuentaConParametroOpcional(double totalCuenta, double propina, int comensales, double estacionamiento = 0, double iva = 15)
        {
            return (totalCuenta + propina+ estacionamiento + iva) / comensales;
        }

        static double CalcularCuenta(double totalCuenta, double propina, int comensales)
        {
            return (totalCuenta + propina) / comensales;
        }
        static double CalcularCuenta(double totalCuenta, double propina, int comensales, double estacionamiento)
        {
            return (totalCuenta + propina + estacionamiento) / comensales;
        }

        static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        static float Multiplicar(float numero2, int numero3)
        {
            return numero2 * numero3;
        }

        static void Saludar2()
        {
            nombre = "Miguel";
            Console.WriteLine(nombre);
        }
        static void Saludar() => Console.WriteLine($"Hola {nombre}");

        static (int, int) Dividir(int numero1, int numero2)
        {
            int cociente = numero1 / numero2;
            int residuo = numero1 % numero2;
            return (cociente, residuo);
        }

        static (int, int, string) RegresarDatos()
        {
            return (8, 3, "soy el string");
        }
    }
}
