using Biblioteca.Dtos;
using Biblioteca.Servicios;

namespace Biblioteca.Controladores
{
    class program
    {
        //Listas de las clases
        public static List<BibliotecasDto> bibliotecaLista = new List<BibliotecasDto>();
        public static List<ClientesDto> clienteLista = new List<ClientesDto>();
        public static List<LibrosDto> librosLista = new List<LibrosDto>();
        public static List<PrestamosDto> prestamosLista = new List<PrestamosDto>();

        public static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;

            //Constructores de las clases e interfaces
            MenuInterfaz mi = new MenuImplementacion();
            BibliotecaImplementacion bl = new BibliotecaImplementacion();
          

            //Creacion de los ficheros
            string ficheroErrores = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficheroErrores";
            string ficheroBibliotecaTotal = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficheroBibliotecaTotal";
            string ficheroClientes = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficheroClientes";
            string ficheroLibros = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficherosLibros";
            string ficheroPrestamos = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficherosPrestamos";
        
            //Variables de flujo
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
                            //Guardar ficheros
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

        //Sirve para utilizarlo de Fk entre las demas funcionalidades y relacionarlas con la biblioteca(nos falta instanciarla)
        public static long idBiblioteca;
    }
}