using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class Vehiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

        public int Annio { get; set; }

        public Vehiculo() { }

        public Vehiculo(string marca, string modelo, int annio)
        {
            Marca = marca;
            Modelo = modelo;
            Annio = annio;
        }


        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Annio: {Annio}");
        }
    }
}
