using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Controladores;
using Biblioteca.Dtos;
using Biblioteca.Utilidades;

namespace Biblioteca.Servicios
{
    internal class ClienteImplementacion : Operativa
    {
        Utilidades.Utilidades ut = new Utilidades.Utilidades();

        override
        public void alta()
        {
            long idCliente = idAutomatico();
            Console.WriteLine("Dame el nombre del nuevo cliente");
            string nombreCliente = Console.ReadLine();
            Console.WriteLine("Dame la fecha de nacimiento del nuevo cliente con el siguiente formato(dd/MM/yyyy)");
            DateTime fechaNacimientoCliente = DateTime.Parse(Console.ReadLine());
            string DNICliente = ut.validarDNI();
            Console.WriteLine("Dame el correo electronico del nuevo cliente");
            string correoCliente = Console.ReadLine();
            Console.WriteLine(correoCliente);
            long identificadorBL = program.idBiblioteca;

            ClientesDto nuevoCliente = new ClientesDto(idCliente,nombreCliente,fechaNacimientoCliente,DNICliente,correoCliente,identificadorBL);
            program.clienteLista.Add(nuevoCliente);
        }

        private long idAutomatico()
        {
            long idAutomatico;
            if (program.clienteLista.Count <= 0)
            {
                idAutomatico = 1;
            }
            else
            {
                idAutomatico = program.clienteLista[program.clienteLista.Count - 1].IdClientes + 1;
            }

            return idAutomatico;
        }
    }
}
