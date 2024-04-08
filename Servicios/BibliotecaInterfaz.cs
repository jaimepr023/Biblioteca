using Biblioteca.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Servicios
{
    internal interface BibliotecaInterfaz
    {
        public void darAltaBiblioteca(List<BibliotecasDto> ListaB);
    }
}
