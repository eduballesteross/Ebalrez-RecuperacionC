using Ebalrez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    /// <summary>
    /// Listado de métodos relacionados con la operativa de la aplicación
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método para dar alta cliente 
        /// </summary>
        /// <param name="listaPropietario"></param>
        public void darAltaCliente(List<PropietarioDto> listaPropietario);

        /// <summary>
        /// Método que completa el campo es historico y muestra el numero de coches historicos de coches que hay.
        /// </summary>
        /// <param name="listaPropietarios"></param>
        /// <param name="listaVehiculos"></param>
        public void numeroHistorico(List<PropietarioDto>listaPropietarios,List<VehiculosDto> listaVehiculos);    
    }
}
