using Biblioteca.Controladores;
using Biblioteca.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Servicios
{
    internal abstract class Operativa
    {
        //metodo abstracto que se sobreescribe en la clase biblioteca
        public abstract void alta();

        //Metodo no abstracto que se realiza aqui pero al llamarlo sera en cualquier clase a la que hayamos implementado con esta
        public void acceso()
        {
                List<long> todosLosIdsBiblios = new List<long>();
                long identificadorGlobal;
            foreach (BibliotecasDto biblio in program.bibliotecaLista)
            {
                    Console.WriteLine($"Id-->{biblio.IdBiblioteca}\n" +
                        $"Nombre-->{biblio.NombreBiblioteca}\n");
                    todosLosIdsBiblios.Add(biblio.IdBiblioteca);

            }

            do
            {
                //Metodo estatico que verifica el id de la biblioteca
                Console.WriteLine("Dame el codigo para verificar a que biblioteca quieres acceder");
                identificadorGlobal = Int32.Parse(Console.ReadLine());
            } while (!todosLosIdsBiblios.Contains(identificadorGlobal));    
            program.idBiblioteca= identificadorGlobal;
        }
    }
}
