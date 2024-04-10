using Biblioteca.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Controladores;

namespace Biblioteca.Servicios
{
    internal class BibliotecaImplementacion : Operativa
    {
        override
        public  void alta()
        {
            Console.WriteLine("Alta de una nueva biblioteca");
            long id = idAutomatico();
            Console.WriteLine("Dame el nombre de la nueva biblioteca:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dame la direccion donde se encuentra la nueva biblioteca:");
            string direccion = Console.ReadLine();
            BibliotecasDto bibl = new BibliotecasDto(id, nombre, direccion);
            program.bibliotecaLista.Add(bibl);

        }
        private long idAutomatico()
        {
            long idAutomatico;
            if (program.bibliotecaLista.Count <= 0)
            {
                idAutomatico = 1;
            }
            else
            {
                idAutomatico = program.bibliotecaLista[program.bibliotecaLista.Count - 1].IdBiblioteca + 1;
            }

            return idAutomatico;
        }
    }
}
