using System;

class Program
{
    static void Main()
    {
        // comentario normal
        /*
        HolaMundo
        como 
        estas ?
        */

        Console.WriteLine("Hola Mundo !!!");

        int entero = 2147483647;
        Console.WriteLine(entero);

        long entero2 = 21474836488923;
        Console.WriteLine(entero2);

        float numeroFloat1 = 3.1416f;
        Console.WriteLine(numeroFloat1);

        float numeroFloat2 = 214.321654987654654f;
        Console.Write(numeroFloat2);

        double numeroDouble1 = 3.1416;
        Console.WriteLine(numeroDouble1);

        double numeroDouble2 = 214.321654987654654;
        Console.WriteLine(numeroDouble2);

        decimal numeroDecimal1 = 3.1415m;
        Console.WriteLine(numeroDecimal1);

        decimal numeroDecimal2 = 24.74838273328763223m;
        Console.WriteLine(numeroDecimal2);

        // declarar variables
        // tipo de dato + nombre + ";"

        string soyElString = "hola soy el string";
        Console.WriteLine(soyElString);

        bool isValid = false;
        Console.WriteLine(isValid);

        char character = 'x';
        Console.WriteLine(character);

        // operadores aritmeticos
        //  + - * / 
        
        Console.ReadLine();
    }
}