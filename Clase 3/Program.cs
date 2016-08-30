using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*eFabricante fabricante; //var de tipo enumerado

            fabricante = (eFabricante) 1; //Casteamos el numero 3 al tipo de dato del enumerado

            Console.WriteLine(fabricante);
            Console.ReadKey();

            //Rueda nuevarueda = new Rueda();*/

            //Rueda otrarueda = new Rueda(39);

            Carrera nuevacarrera = new Carrera();

            /*Tiempo nuevotiempo = new Tiempo(30);

            nuevacarrera.correrCarrera(nuevotiempo);

            Kilometros nuevokm = new Kilometros(30);

            nuevacarrera.correrCarrera(nuevokm);

            nuevacarrera.MostrarCarrera();

            nuevotiempo = nuevotiempo + 10;*/

            Tiempo time = 20;
            Kilometros km = 5;

            nuevacarrera.correrCarrera(time);
            nuevacarrera.correrCarrera(km);

            nuevacarrera.MostrarCarrera();            

            Console.ReadKey();
        }
    }
}
