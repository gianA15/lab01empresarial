using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class Camion : Vehiculo
    {
        
        public double CapacidadCarga { get; set; }

        public Camion(string marca, string modelo, int annio, double capacidadCarga)
        {
            Marca = marca;
            Modelo = modelo;
            Annio = annio;
            CapacidadCarga = capacidadCarga;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Capacidad de Carga: {CapacidadCarga}");
        }
    }
}
