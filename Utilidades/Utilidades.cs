using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Utilidades
{
    internal class Utilidades
    {
        public string validarDNI()
        {
            char[] letras = new char[] { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            int dniNum;
            char letra;
            bool comprobante = false;

            do
            {
                Console.WriteLine("Dame el dni(Numero)");
                dniNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Dame el dni(Letra)");
                letra = Convert.ToChar(Console.ReadLine());
                int resto = dniNum % 23;
                if (letras[resto] == letra)
                {
                    comprobante = true;
                }
                else
                {
                    comprobante = false;
                }

            }while(!comprobante);
           
            string dni= dniNum+""+letra;    
            return dni;
        }

    }
}
