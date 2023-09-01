using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class Automovil : Vehiculo
    {
        public string Combustible { get; set; }

        public Automovil(string marca, string modelo, int annio, string combustible)
        {
            Marca = marca;
            Modelo = modelo;
            Annio = annio;
            Combustible = combustible;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Combustible: {Combustible}");
        }
    }
}
