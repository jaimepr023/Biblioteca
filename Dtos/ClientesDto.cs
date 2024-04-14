using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dtos
{
    internal class ClientesDto
    {
        long idClientes;
        long identificadorBibliotecaCliente;
        string nombreCliente = "aaaaa";
        DateTime fechaNacimiento = new DateTime();
        string dNICliente = "aaaaa";
        string correoCliente = "aaaaa";
        DateTime fechaInicioSupension = new DateTime();
        DateTime fechaFinSupension = new DateTime();

        public long IdClientes { get => idClientes; set => idClientes = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string DNICliente { get => dNICliente; set => dNICliente = value; }
        public string CorreoCliente { get => correoCliente; set => correoCliente = value; }
        public DateTime FechaInicioSupension { get => fechaInicioSupension; set => fechaInicioSupension = value; }
        public DateTime FechaFinSupension { get => fechaFinSupension; set => fechaFinSupension = value; }
        public long IdentificadorBibliotecaCliente { get => identificadorBibliotecaCliente; set => identificadorBibliotecaCliente = value; }

        public ClientesDto(long idClientes, string nombreCliente, DateTime fechaNacimiento, string dNICliente, string correoCliente, long identificadorBibliotecaCliente)
        {
            this.idClientes = idClientes;
            this.nombreCliente = nombreCliente;
            this.fechaNacimiento = fechaNacimiento;
            this.dNICliente = dNICliente;
            this.correoCliente = correoCliente;
            this.identificadorBibliotecaCliente = identificadorBibliotecaCliente;
            this.fechaInicioSupension = fechaInicioSupension;
            this.fechaFinSupension = fechaFinSupension;
        }

        public ClientesDto()
        {
        }
    }
}
