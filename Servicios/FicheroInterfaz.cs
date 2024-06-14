using Ebalrez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    /// <summary>
    /// Listado de todos los métodos relacionados con ficheros
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Listado con la funcianalidad de leer fichero
        /// 1406024-ebp
        /// </summary>
        /// <param name="listaPropietarios"></param>
        /// <param name="listaVehiculos"></param>
        public void leerFicheros(List<PropietarioDto>listaPropietarios, List<VehiculosDto>listaVehiculos);

        /// <summary>
        /// Método que crea el fichero log
        /// </summary>
        public void ficheroLog(string texto);
    }
}
