using Biblioteca.Dtos;
using Biblioteca.Servicios;

namespace Biblioteca.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;

            MenuInterfaz mi = new MenuImplementacion();
            BibliotecaInterfaz bl = new BibliotecaImplementacion();

            List<BibliotecasDto> bibliotecaLista = new List<BibliotecasDto> ();
            List<ClientesDto> clienteLista = new List<ClientesDto> ();
            List<LibrosDto> librosLista = new List<LibrosDto> ();
            List<PrestamosDto> prestamosLista = new List<PrestamosDto> ();

            string ficheroErrores = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficheroErrores";
            string ficheroBibliotecaTotal = "C:\\Users\\profesor\\Desktop\\Biblioteca\\ficheroBibliotecaTotal";
            

            int opcionMenuPrincipal;
            int segundoMenuOpcion;
            bool cerrarMenu=false;


            string[] todasBiblios = File.ReadAllLines(ficheroBibliotecaTotal);
            Console.WriteLine("Aqui observaras todas las bibliotecas que se encuentran disponible");
            foreach(string line in todasBiblios)
            {
                Console.WriteLine(line);
            }
            StreamWriter swbt = new StreamWriter(ficheroBibliotecaTotal, true);
            StreamWriter swb = new StreamWriter(ficheroBibliotecaTotal, true);

            try
            {
                do
                {
                    opcionMenuPrincipal = mi.menuInicial();
                    switch (opcionMenuPrincipal)
                    {
                        case 0:
                            cerrarMenu = true;
                            break;
                        case 1:
                            bl.darAltaBiblioteca(bibliotecaLista);
                            
                                    swbt.Write($"------------------------------------------ \n" +
                                        $"Fecha del registro-->{fecha}" +
                                        $"Id--> {bibliotecaLista[bibliotecaLista.Count-1].IdBiblioteca}\n" +
                                        $"Nombre-->{bibliotecaLista[bibliotecaLista.Count - 1].NombreBiblioteca}\n" +
                                        $"Direccion--> {bibliotecaLista[bibliotecaLista.Count - 1].DireccionBiblioteca}\n" +
                                        $"------------------------------------------");
                             
                            
                            string ficheroBiblio = $"C:\\Users\\profesor\\Desktop\\Biblioteca\\{bibliotecaLista[bibliotecaLista.Count - 1].NombreBiblioteca}";
                            break;
                        case 2:
                            if (bibliotecaLista.Count > 0)
                            {
                                Console.WriteLine("Dame el nombre de la biblioteca a la que quieres entrar:");
                                string confirmacionNombre = Console.ReadLine();
                                foreach (BibliotecasDto biblio in bibliotecaLista)
                                {
                                    if (biblio.NombreBiblioteca.Equals(confirmacionNombre))
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
            }catch (Exception e)
            {
                Console.WriteLine("la pagina esta ahora mismo deshabilitada, por favor intentole de nuevo en 5 minutos");
                StreamWriter sw1 = new StreamWriter(ficheroErrores);
                sw1.WriteLine(e.Message);
                sw1.Close();

            }

            swb.Close();
            swbt.Close();
            

        }
    }
}