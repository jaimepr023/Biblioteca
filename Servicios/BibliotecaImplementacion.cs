using Biblioteca.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Servicios
{
    internal class BibliotecaImplementacion : BibliotecaInterfaz
    {
        public void darAltaBiblioteca(List<BibliotecasDto> ListaB)
        {
            long id = idAutomatico(ListaB);
            Console.WriteLine("Dame el nombre de la nueva biblioteca:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dame la direccion donde se encuentra la nueva biblioteca:");
            string direccion = Console.ReadLine();
            BibliotecasDto bibl = new BibliotecasDto(id,nombre,direccion);
            ListaB.Add(bibl);
            
        }

        private long idAutomatico(List<BibliotecasDto> ListaB)
        {
           int tamañoLista = ListaB.Count;
            long idAutomatico;
            if (tamañoLista <= 0)
            {
                idAutomatico = 1;
            }
            else
            {
                idAutomatico = ListaB[tamañoLista - 1].IdBiblioteca + 1;
            }

            return idAutomatico;
        }
    }
}
