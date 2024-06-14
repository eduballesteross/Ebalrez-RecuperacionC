using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    /// <summary>
    /// Implementacion de InterfazMenu
    /// 14062024-ebalrez
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuPrincipal()
        {
            int opcion;

            Console.WriteLine("#######################");
            Console.WriteLine(" 0 - Cerrar Aplicación");
            Console.WriteLine(" 1 - Número de historicos");
            Console.WriteLine(" 2 - Alta Nuevo Propietario");
            Console.WriteLine("#######################");

            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;  
        }
    }
}
