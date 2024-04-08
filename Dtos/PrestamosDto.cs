using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dtos
{
    internal class PrestamosDto
    {
        int idPrestamo;
        int identificadorCliente = 0;
        int identificadorLibro=0;
        DateTime fechaPrestamo = DateTime.Today;
        DateTime fechaLibro = new DateTime(31 - 12 - 9999);

        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public int IdentificadorCliente { get => identificadorCliente; set => identificadorCliente = value; }
        public int IdentificadorLibro { get => identificadorLibro; set => identificadorLibro = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaLibro { get => fechaLibro; set => fechaLibro = value; }

        public PrestamosDto(int idPrestamo, int identificadorCliente, int identificadorLibro)
        {
            this.idPrestamo = idPrestamo;
            this.identificadorCliente = identificadorCliente;
            this.identificadorLibro = identificadorLibro;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaLibro = fechaLibro;
        }

        public PrestamosDto()
        {
        }
    }
}
