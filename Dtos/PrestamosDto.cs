﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dtos
{
    internal class PrestamosDto
    {
        long idPrestamo;
     
        long identificadorClientePrestamo;
        long identificadorLibroPrestamo;
        int identificadorCliente = 0;
        int identificadorLibro=0;
        DateTime fechaPrestamo = DateTime.Today;
        DateTime fechaLibro = new DateTime(31 - 12 - 9999);
        string estadoPrestamos = "En proceso";

        public long IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public int IdentificadorCliente { get => identificadorCliente; set => identificadorCliente = value; }
        public int IdentificadorLibro { get => identificadorLibro; set => identificadorLibro = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaLibro { get => fechaLibro; set => fechaLibro = value; }
        public long IdentificadorClientePrestamo { get => identificadorClientePrestamo; set => identificadorClientePrestamo = value; }
        public long IdentificadorLibroPrestamo { get => identificadorLibroPrestamo; set => identificadorLibroPrestamo = value; }
        public string EstadoPrestamos { get => estadoPrestamos; set => estadoPrestamos = value; }

        public PrestamosDto(long idPrestamo, long identificadorClientePrestamo, long identificadorLibroPrestamo, int identificadorCliente, int identificadorLibro, string estadoPrestamos)
        {
            this.idPrestamo = idPrestamo;
            this.identificadorClientePrestamo = identificadorClientePrestamo;
            this.identificadorLibroPrestamo = identificadorLibroPrestamo;
            this.identificadorCliente = identificadorCliente;
            this.identificadorLibro = identificadorLibro;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaLibro = fechaLibro;
            this.estadoPrestamos = estadoPrestamos;
            FechaPrestamo = fechaPrestamo;
            FechaLibro = fechaLibro;

        }

        public PrestamosDto()
        {
        }
    }
}
