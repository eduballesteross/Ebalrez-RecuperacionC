using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    /// <summary>
    /// Listado de métodos relacionados con los menús de la aplicación;
    /// 14062024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menu Principal y recoge su opcion.
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuPrincipal();
    }
}
