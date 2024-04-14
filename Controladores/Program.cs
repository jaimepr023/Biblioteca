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
            BibliotecaImplementacion bl = new BibliotecaImplementacion();
            ClienteImplementacion cl = new ClienteImplementacion(); 
          

            //Creacion de los ficheros
            string ficheroErrores = "C:\\Users\\vspc\\OneDrive\\Escritorio\\Biblioteca\\ficheroErrores";
            string ficheroBibliotecaTotal = "C:\\Users\\vspc\\OneDrive\\Escritorio\\Biblioteca\\ficheroBibliotecaTotal";
            string ficheroClientes = "C:\\Users\\vspc\\OneDrive\\Escritorio\\Biblioteca\\ficheroClientes";
            string ficheroLibros = "C:\\Users\\vspc\\OneDrive\\Escritorio\\Biblioteca\\ficherosLibros";
            string ficheroPrestamos = "C:\\Users\\vspc\\OneDrive\\Escritorio\\Biblioteca\\ficherosPrestamos";
        
            //Variables de flujo
            int opcionMenuPrincipal;
            int segundoMenuOpcion;
            bool cerrarMenu=false;

            try
            {
                //Aqui tendria que hacerse la añadida de la documentacion anterior de las listas
                //Condicion de si existe el fichero se muestre por pantalla el contenido
                condicionDeMostrarContenido(ficheroBibliotecaTotal);
                guardarClienteBDD(ficheroClientes);

                do
                {
                    opcionMenuPrincipal = mi.menuInicial();
                    switch (opcionMenuPrincipal)
                    {
                        case 0:
                            //Guardar ficheros
                            //Biblios
                            StreamWriter swBLT = new StreamWriter(ficheroBibliotecaTotal);
                            foreach (BibliotecasDto biblio in bibliotecaLista)
                            {
                                swBLT.Write($"{biblio.IdBiblioteca};{biblio.NombreBiblioteca};{biblio.DireccionBiblioteca} \n");
                            }
                            swBLT.Close();

                            //Clientes
                            StreamWriter swC = new StreamWriter(ficheroClientes);
                            foreach (ClientesDto client in clienteLista)
                            {
                                swC.Write($"{client.IdClientes};{client.NombreCliente};{client.FechaNacimiento};{client.DNICliente};{client.CorreoCliente};{client.IdentificadorBibliotecaCliente}\n");
                            }
                            swC.Close();
                            cerrarMenu = true;
                            break;
                        case 1:
                            bl.alta();
                            break;
                        case 2:
                         
                            //Condicion de que si no hay bibliotecas no puedes utilizar esta funcion
                            if (program.bibliotecaLista.Count > 0)
                            {
                                //Metodo acceso realizado en la clase opeativa e instanciado por la clase biblioteca
                                bl.acceso();
                                switch (segundoMenuOpcion= mi.menuSecundario())
                                {
                                    case 0:
                                        Console.WriteLine("[INFOS]- Se volvera a la pagina principal");
                                        break;
                                    case 1:
                                        cl.alta();
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
            }
            catch (Exception e)
            {
                Console.WriteLine("la pagina esta ahora mismo deshabilitada, por favor intentole de nuevo en 5 minutos");
                StreamWriter swE = new StreamWriter(ficheroErrores);
                swE.WriteLine(e.Message + "-->" + fecha);
                swE.Write(e.StackTrace);
                swE.Close();

            }
        }

        //Listas de las clases en forma estatica para tenerlo mas a mano a la hora de llamarlos
        public static List<BibliotecasDto> bibliotecaLista = new List<BibliotecasDto>();
        public static List<ClientesDto> clienteLista = new List<ClientesDto>();
        public static List<LibrosDto> librosLista = new List<LibrosDto>();
        public static List<PrestamosDto> prestamosLista = new List<PrestamosDto>();


        //Metodo que muestra la si hay fichero en el fichero todo el contenido y gurda el contenido de los ficheros en las listas  
        public static void condicionDeMostrarContenido(string ficheroBibliotecaTotal)
        {
            if (File.Exists(ficheroBibliotecaTotal))
            {
                string[] contenidoFichero = File.ReadAllLines(ficheroBibliotecaTotal);
                foreach (string contenido in contenidoFichero)
                {
                    string[] partesDeLaLineas = contenido.Split(';');
                    BibliotecasDto biblio2 = new BibliotecasDto(Int64.Parse(partesDeLaLineas[0]), partesDeLaLineas[1], partesDeLaLineas[2]);
                    program.bibliotecaLista.Add(biblio2);
                }

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

        //Se guarda el contenido de los dias anteriores en las listas de nuevo como una base de dtos
        public static void guardarClienteBDD(string ficheroCliente)
        {
            if (File.Exists(ficheroCliente))
            {
                string[] contenidoFichero = File.ReadAllLines(ficheroCliente);
                foreach (string contenido in contenidoFichero)
                {
                    string[] partesDeLaLineas = contenido.Split(';');
                    ClientesDto client2 = new ClientesDto(Int64.Parse(partesDeLaLineas[0]), partesDeLaLineas[1], DateTime.Parse(partesDeLaLineas[2]), partesDeLaLineas[3], partesDeLaLineas[4], Int64.Parse(partesDeLaLineas[5]));
                }
            }
            else
            {
                Console.WriteLine("No hay ningun cliente disponible");
            }
        }


        //Sirve para utilizarlo de Fk entre las demas funcionalidades y relacionarlas con la biblioteca(nos falta instanciarla)
        public static long idBiblioteca;
    }
}