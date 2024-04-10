using Biblioteca.Controladores;
using Biblioteca.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Servicios
{
    internal abstract class Operativa
    {
        public abstract void alta();

        public void acceso()
        {
            if (program.bibliotecaLista.Count > 0)
            {
                //Metodo estatico que verifica el id de la biblioteca
                Console.WriteLine("Dame el codigo para verificar a que biblioteca quieres acceder");
                long identificadorGlobal = Int32.Parse(Console.ReadLine());

                
            }
            else
            {
                Console.WriteLine("Deberias de meter alguna biblioteca para que funcione esta parte de la aplicacion");
            }
        }
    }
}
