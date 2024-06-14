using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Dtos
{
    /// <summary>
    /// Entidad Vehiculo
    /// 140624-ebp
    /// </summary>
    internal class VehiculosDto
    {
        long idVehiculo;
        string matriculaVehiculo = "aaaaaaaaaa";
        DateTime fechaMatricula = DateTime.Now;

        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string MatriculaVehiculo { get => matriculaVehiculo; set => matriculaVehiculo = value; }
        public DateTime FechaMatricula { get => fechaMatricula; set => fechaMatricula = value; }
    }
}
