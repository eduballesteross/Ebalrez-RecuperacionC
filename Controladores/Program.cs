using Ebalrez.Dtos;
using Ebalrez.Servicios;

namespace Ebalrez.Controladores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         
        List<VehiculosDto> listaVehiculos = new List<VehiculosDto>();   
        List<PropietarioDto>listaPropietarios = new List<PropietarioDto>();
            
         FicheroInterfaz ficheroI = new FicheroImplementacion(); 
         MenuInterfaz menuI = new MenuImplementacion(); 
         OperativaInterfaz operativaI = new OperativaImplementacion();


            
            bool cerrarMenu = false;
            int opcion;

            ficheroI.leerFicheros(listaPropietarios, listaVehiculos);

            while (!cerrarMenu) 
            {

                opcion = menuI.mostrarMenuPrincipal();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Has seleccionado la opcion de cerrar Menu ");
                        ficheroI.ficheroLog("Has seleccionado la opcion de cerrar Menu");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Has seleccionado la opcion de números de historicos.");
                        ficheroI.ficheroLog("Has seleccionado la opcion de numeros de historicos.");
                        operativaI.numeroHistorico(listaPropietarios, listaVehiculos);
                        break;

                    case 2:
                        Console.WriteLine("Has seleccionado la opcion de dar alta cliente. ");
                        ficheroI.ficheroLog("Has seleccionado la opcion de alta nuevo propietario.");

                        operativaI.darAltaCliente(listaPropietarios);

                        break;

                    default:
                        Console.WriteLine("Has seleccionado una opcion incorrecta.");
                        ficheroI.ficheroLog("Has seleccionado una opcion incorrecta.");
                            break;
                }

            }

        }
    }
}