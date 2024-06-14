using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Dtos
{
    /// <summary>
    /// Entidad Propietario
    /// 140624-ebp
    /// </summary>
    internal class PropietarioDto
    {
        long idPropietario;
        string dniPropietario;
        DateTime fechaCompra = DateTime.Now;    
        int esHistorico = 0;

        public long IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string DniPropietario { get => dniPropietario; set => dniPropietario = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public int EsHistorico { get => esHistorico; set => esHistorico = value; }

        /// <summary>
        /// Método To String para mostra la entidad
        /// 14062024-ebp
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            string formato = String.Concat("Nuevo Propietario: ",this.idPropietario,"-",this.dniPropietario);
            return formato; 
        }
    }
}
