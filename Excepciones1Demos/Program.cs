using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones1Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int valor = 10;
                Console.WriteLine(valor / 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                string numeroEnCadena = "1a";
                int valor = int.Parse(numeroEnCadena);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                string numeroGrande = "9999999999999";
                int numeroConvertido = int.Parse(numeroGrande);

            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);    
            }


            Console.ReadLine();
        }
    }
}
