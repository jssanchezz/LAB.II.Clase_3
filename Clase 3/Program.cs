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
           

            Carrera nuevacarrera = new Carrera();

            Tiempo time = 20;
            Kilometros km = 5;

            nuevacarrera.correrCarrera(time);
            nuevacarrera.correrCarrera(km);

            nuevacarrera.MostrarCarrera();

            Console.ReadKey();
        }
    }
}
