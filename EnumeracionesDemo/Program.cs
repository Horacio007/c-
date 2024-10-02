using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracionesDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Administrador -1 
            // Desarrollador - 2
            // Usuario Final - 3

            Rol tipoUsuario = Rol.Administrador;

            if (tipoUsuario == Rol.Administrador)
            {
                tipoUsuario++;
            }

            Rol? tipoUsuario2 = null;

            switch (tipoUsuario)
            {
                case Rol.Administrador: 
                    Console.WriteLine(((int)Rol.UsuarioFinal));
                    break;
                case Rol.Desarrollador: Console.WriteLine("Desarrollador");
                    break;
                case Rol.UsuarioFinal: Console.WriteLine("UsuarioFinal");
                    break;
            }

            Console.ReadLine();

        }
        public static void ValidarUsuario(Rol rol)
        {

        }

    }
}
