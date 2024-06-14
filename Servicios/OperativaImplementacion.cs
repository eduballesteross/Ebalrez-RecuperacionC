using Ebalrez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaCliente(List<PropietarioDto> listaPropietario)
        {
            PropietarioDto propietario = new PropietarioDto();  

            propietario.IdPropietario=calcularID(listaPropietario);


            bool aux = false;

            while (!aux)
            {
                Console.WriteLine("Introduzca su DNI.");
                string dniAux = Console.ReadLine();

                if (dniAux.Length==9)
                {
                    propietario.DniPropietario = dniAux;
                    Console.WriteLine("Has introduciod un DNI con exito.");
                    aux = true;
                }
                else
                {
                    Console.WriteLine("Has introduciod un DNI incorrecto");
                    aux = false;
                }

            }

            listaPropietario.Add(propietario);

            foreach(PropietarioDto prop in listaPropietario)
            {
                Console.WriteLine(propietario.ToString());
                break;
            }
        }

        public void numeroHistorico(List<PropietarioDto> listaPropietarios, List<VehiculosDto> listaVehiculos)
        {
            DateTime fechaActual = DateTime.Now;

            VehiculosDto vh =  new VehiculosDto();
            

          

            int añoHoy= fechaActual.Year;
            int aux2 = 0;
            

            foreach(VehiculosDto veh in listaVehiculos)
            {
               int resultado = añoHoy - veh.FechaMatricula.Year;

               if(resultado > 25)
                {
                    foreach(PropietarioDto propo in listaPropietarios)
                    {
                        propo.EsHistorico = 1;

                        if(propo.EsHistorico == 1)
                        {
                            int aux = 1;
                            aux2 = aux;
                        }

                    }

                    Console.WriteLine("NªHistoricos: "+aux2);
                }

                
            }

             

        }

        

        

        private long calcularID(List<PropietarioDto> listaPropietario)
        {
            long idAux;

            if (listaPropietario.Count==0)
            {
                idAux = 0;
            }
            else
            {
                long idMax = listaPropietario.Max(v=>v.IdPropietario);
                idAux = idMax+1;
            }

            return idAux;   
        }
    }
}
