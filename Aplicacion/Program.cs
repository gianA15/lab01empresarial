// See https://aka.ms/new-console-template for more information

using Aplicacion;
using System.Runtime.InteropServices;

Vehiculo vehiculo = new Vehiculo("","",0);
vehiculo.Marca = "Toyota";
vehiculo.Modelo = "Modelo";
vehiculo.Annio = 2022;



Automovil automovil = new Automovil("Toyota", "Yaris", 2013, "200");
Camion camion = new Camion("Nissan", "Sentra", 2010, 12);


Flota flota = new Flota(new List<Vehiculo> { automovil, camion });
flota.MostrarFlota();




