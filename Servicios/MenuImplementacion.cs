using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuInicial()
        {
            int opcion;
            Console.WriteLine("----------------------");
            Console.WriteLine("Opcion 0. Cerrar menu");
            Console.WriteLine("Opcion 1. Dar alta a una nueva biblioteca");
            Console.WriteLine("Opcion 2. Entrar en una biblioteca especifica");
            Console.WriteLine("----------------------");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }

        public int menuSecundario()
        {
            int opcion;
            Console.WriteLine("----------------------");
            Console.WriteLine("Opcion 0. Volver");
            Console.WriteLine("Opcion 1. Dar alta a un nuevo cliente");
            Console.WriteLine("Opcion 2. Dar alta a un nuevo libro");
            Console.WriteLine("Opcion 3. Hacer un nuevo prestamo");
            Console.WriteLine("----------------------");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
