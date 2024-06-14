using Ebalrez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    /// <summary>
    /// Implementacion de ficherointerfaz
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void ficheroLog(string t)
        {
            try 
            {
                DateTime fechaHoy = DateTime.Now;

                string rutaFichero = String.Concat("log-", fechaHoy.ToString("dd-MM-yyyyy"), ".txt");
                StreamWriter sw = new StreamWriter(rutaFichero, true);

                sw.WriteLine(String.Concat("[INFO]", t));

                sw.Close();
            }
            catch (IOException ex){ Console.WriteLine(ex.ToString); }  
           

        }

        public void leerFicheros(List<PropietarioDto> listaPropietarios, List<VehiculosDto> listaVehiculos)
        {
            try
            {
                string rutaFichero = "datosIniciales.txt";

                string[] lineas = File.ReadAllLines(rutaFichero);

                foreach (string line in lineas)
                {
                    string[] propietario = line.Split(':');
                    string[] vehiculos = line.Split(":");

                    PropietarioDto prop = new PropietarioDto();
                    VehiculosDto veh = new VehiculosDto();

                    veh.IdVehiculo = Convert.ToInt64(vehiculos[0]);
                    veh.MatriculaVehiculo = vehiculos[1];
                    veh.FechaMatricula = Convert.ToDateTime(vehiculos[2]);
                    prop.IdPropietario = Convert.ToInt64(propietario[3]);
                    prop.DniPropietario = propietario[4];
                    prop.FechaCompra = Convert.ToDateTime(propietario[5]);

                    listaPropietarios.Add(prop);
                    listaVehiculos.Add(veh);

                    Console.WriteLine(veh.IdVehiculo+veh.MatriculaVehiculo+prop.IdPropietario+prop.DniPropietario+prop.FechaCompra);

                    Console.WriteLine("La carga ha sido realizada con éxito.");
                }
           
            }catch (Exception ex) { Console.WriteLine("NO SE HA REALIZADO LA CARGA"); }
        }
    }
}
