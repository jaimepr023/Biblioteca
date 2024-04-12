using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dtos
{
    internal class BibliotecasDto
    {
        long idBiblioteca;
        string nombreBiblioteca = "aaaaa";
        string direccionBiblioteca = "aaaaa";

        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string DireccionBiblioteca { get => direccionBiblioteca; set => direccionBiblioteca = value; }

        public BibliotecasDto(long idBiblioteca, string nombreBiblioteca, string direccionBiblioteca)
        {
            this.idBiblioteca = idBiblioteca;
            this.nombreBiblioteca = nombreBiblioteca;
            this.direccionBiblioteca = direccionBiblioteca;

        }

        public BibliotecasDto()
        {
        }  
    }
}
