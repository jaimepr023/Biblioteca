using Biblioteca.Dtos;
using Biblioteca.Servicios;

namespace Biblioteca.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;

            //Constructores de las clases e interfaces
            MenuInterfaz mi = new MenuImplementacion();
            BibliotecaInterfaz bl = new BibliotecaImplementacion();
            ClienteInterfaz Cl = new ClienteImplementacion();

            //Listas de las clases
            List<BibliotecasDto> bibliotecaLista = new List<BibliotecasDto> ();
            List<ClientesDto> clienteLista = new List<ClientesDto> ();
            List<LibrosDto> librosLista = new List<LibrosDto> ();
            List<PrestamosDto> prestamosLista = new List<PrestamosDto> ();


            //Creacion de los ficheros
            string ficheroErrores = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficheroErrores";
            string ficheroBibliotecaTotal = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficheroBibliotecaTotal";
            string ficheroClientes = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficheroClientes";
            string ficheroLibros = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficherosLibros";
            string ficheroPrestamos = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficherosPrestamos";


            int opcionMenuPrincipal;
            int segundoMenuOpcion;
            bool cerrarMenu=false;

          
            

            try
            {
                do
                {
                    //Condicion de si existe el fichero se muestre por pantalla el contenido
                    condicionDeMostrarContenido(ficheroBibliotecaTotal);

                    opcionMenuPrincipal = mi.menuInicial();
                    switch (opcionMenuPrincipal)
                    {
                        case 0:
                            cerrarMenu = true;
                            break;
                        case 1:
                            bl.darAltaBiblioteca(bibliotecaLista);
                            break;
                        case 2:
                            //Condicion de que si no hay bibliotecas no puedes utilizar esta funcion
                            if (bibliotecaLista.Count > 0)
                            {
                                //Tendria que ir el metodo estatico que verifica el id de la biblioteca
                                Console.WriteLine("Dame el codigo para verificar a que biblioteca quieres acceder");
                                long identificadorGlobal = Int32.Parse(Console.ReadLine());

                                if (validacionIdBiblio(bibliotecaLista))
                                {
                                    segundoMenuOpcion = mi.menuSecundario();
                                    switch (segundoMenuOpcion)
                                    {
                                        case 0:
                                            Console.WriteLine("[INFOS]- Se volvera a la pagina principal");
                                            break;
                                        case 1:
                                            //Cliente Alta
                                            break;
                                        case 2:
                                            //Libro alta
                                            break;
                                        case 3:
                                            //Prestamo Alta
                                            break;
                                        default:
                                            Console.WriteLine("No has elegido ninguna de las opciones anteriormente, se volvera al menu inicial");
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Deberias de meter alguna biblioteca para que funcione esta parte de la aplicacion");
                            }
                            break;
                        default:
                            Console.WriteLine("No has elegido ninguna opcion, por favor elija alguna opcion posible");
                            break;
                    }
                } while (!cerrarMenu);

                /*  swbt.Write($"------------------------------------------ \n" +
                                 $"Fecha del registro-->{fecha}" + "\n" +
                                 $"Id--> {bibliotecaLista[bibliotecaLista.Count - 1].IdBiblioteca}\n" +
                                 $"Nombre-->{bibliotecaLista[bibliotecaLista.Count - 1].NombreBiblioteca}\n" +
                                 $"Direccion--> {bibliotecaLista[bibliotecaLista.Count - 1].DireccionBiblioteca}\n" +
                                 $"------------------------------------------");
             */


            }
            catch (Exception e)
            {
                Console.WriteLine("la pagina esta ahora mismo deshabilitada, por favor intentole de nuevo en 5 minutos");
                StreamWriter swE = new StreamWriter(ficheroErrores);
                swE.WriteLine(e.Message + "-->" + fecha);
                swE.Close();

            }


            

        }

        //Metodo que muestra la si hay fichero en el fichero todo el contenido 
        public static void condicionDeMostrarContenido(string ficheroBibliotecaTotal)
        {
            if (File.Exists(ficheroBibliotecaTotal))
            {
                string[] todasBiblios = File.ReadAllLines(ficheroBibliotecaTotal);
                Console.WriteLine("Aqui observaras todas las bibliotecas que se encuentran disponible");
                foreach (string line in todasBiblios)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No hay ninguna biblioteca disponible para enseñar");
            }
        }

        //Metodo que valida si el id de la biblioteca existe o no
        public static bool validacionIdBiblio(List<BibliotecasDto> bibliotecaLista)
        {
            //Tendria que ir el metodo estatico que verifica el id de la biblioteca
            Console.WriteLine("Dame el codigo para verificar a que biblioteca quieres acceder");
            long identificadorGlobal = Int32.Parse(Console.ReadLine());

            foreach (BibliotecasDto biblio in bibliotecaLista)
            {
                if (biblio.IdBiblioteca == identificadorGlobal)
                {
                    return true;
                }
            }
            return false;
        }
    }
}