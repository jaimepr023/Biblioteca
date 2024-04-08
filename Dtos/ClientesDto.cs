using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dtos
{
    internal class ClientesDto
    {
        int idClientes;
        string nombreCliente = "aaaaa";
        DateTime fechaNacimiento = new DateTime(30 - 12 - 9999);
        string dNICliente = "aaaaa";
        string correoCliente = "aaaaa";
        DateTime fechaInicioSupension = new DateTime(30-12-9999);
        DateTime fechaFinSupension = new DateTime(30 - 12 - 9999);

        public int IdClientes { get => idClientes; set => idClientes = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string DNICliente { get => dNICliente; set => dNICliente = value; }
        public string CorreoCliente { get => correoCliente; set => correoCliente = value; }
        public DateTime FechaInicioSupension { get => fechaInicioSupension; set => fechaInicioSupension = value; }
        public DateTime FechaFinSupension { get => fechaFinSupension; set => fechaFinSupension = value; }

        public ClientesDto(int idClientes, string nombreCliente, DateTime fechaNacimiento, string dNICliente, string correoCliente)
        {
            this.idClientes = idClientes;
            this.nombreCliente = nombreCliente;
            this.fechaNacimiento = fechaNacimiento;
            this.dNICliente = dNICliente;
            this.correoCliente = correoCliente;
            this.fechaInicioSupension = fechaInicioSupension;
            this.fechaFinSupension = fechaFinSupension;
        }

        public ClientesDto()
        {
        }
    }
}
