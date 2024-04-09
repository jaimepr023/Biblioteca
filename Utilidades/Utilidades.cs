using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Utilidades
{
    internal class Utilidades
    {
        public bool validarDNI()
        {
            char[] letras = new char[] { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            Console.WriteLine("Dame el dni(Numero)");
            int dniNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame el dni(Letra)");
            char letra = Convert.ToChar(Console.ReadLine());

            int resto = dniNum % 23;
            if (letras[resto] == letra)
            {
                Console.WriteLine("El DNI es valido");
                return true;
            }
            else
            {
                Console.WriteLine("El DNI no es valido");
                return false;
            }

        }

    }
}
