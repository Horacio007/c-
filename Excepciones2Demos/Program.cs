using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones2Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entero = int.MaxValue;
            checked
            {
                entero++;
            }

            Console.WriteLine(entero);

            Console.ReadLine();
        }
    }
}
