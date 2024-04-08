using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dtos
{
    internal class LibrosDto
    {
        long idLibro;
        string TituloLibro = "aaaaa";
        string subtituloLibro = "aaaaa";
        string autor = "aaaaa";
        string iSBN = "aaaaa";
        int numEdicionLibro = 0;
        string editorialLibro = "aaaaa";
        long strock = 0;

        public long IdLibro { get => idLibro; set => idLibro = value; }
        public string TituloLibro1 { get => TituloLibro; set => TituloLibro = value; }
        public string SubtituloLibro { get => subtituloLibro; set => subtituloLibro = value; }
        public string Autor { get => autor; set => autor = value; }
        public string ISBN { get => iSBN; set => iSBN = value; }
        public int NumEdicionLibro { get => numEdicionLibro; set => numEdicionLibro = value; }
        public string EditorialLibro { get => editorialLibro; set => editorialLibro = value; }
        public long Strock { get => strock; set => strock = value; }

        public LibrosDto(long idLibro, string tituloLibro, string subtituloLibro, string autor, string iSBN, int numEdicionLibro, string editorialLibro, long strock)
        {
            this.idLibro = idLibro;
            TituloLibro = tituloLibro;
            this.subtituloLibro = subtituloLibro;
            this.autor = autor;
            this.iSBN = iSBN;
            this.numEdicionLibro = numEdicionLibro;
            this.editorialLibro = editorialLibro;
            this.strock = strock;
        }

        public LibrosDto()
        {
        }
    }
}
