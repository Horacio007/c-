using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Point? p = new Point();
            //Print(p);

            //StructPoint2 s1 = new StructPoint2();
            //StructPoint2 s2 = s1;

            //Console.WriteLine(s1.X);
            //Console.WriteLine(s2.X);

            //s1.X++;

            //Console.WriteLine(s1.X);
            //Console.WriteLine(s2.X);

            ClassPoint2 s1 = new ClassPoint2();
            ClassPoint2 s2 = s1;

            Console.WriteLine(s1.X);
            Console.WriteLine(s2.X);

            s1.X++;

            Console.WriteLine(s1.X);
            Console.WriteLine(s2.X);

            Console.ReadLine();
        }

        //static void Print(Point? p)
        //{
        //    Console.WriteLine(p.Value.X);
        //}
    }
}
