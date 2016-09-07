using System;
using System.Collections.Generic; //Le agregamos solo un tipo
using System.Collections; //Podemos agregarle cualquier cosa
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Auto> lista;
            lista = new List<Auto>();

            ArrayList Array;

            Array = new ArrayList();

            Stack<Auto> pila; //Concepto de pila, primero en entrar, ultimo en salir
            pila = new Stack<Auto>();

            Queue<Auto> cola; //Concepto de cola, primero en entrar, primero en salir
            cola = new Queue<Auto>();



            Array.Add(new Auto());
            Array.Add("Juan");

            
            /*Carrera nuevacarrera = new Carrera();

            Tiempo time = 20;
            Kilometros km = 5;

            nuevacarrera.correrCarrera(time);
            nuevacarrera.correrCarrera(km);

            nuevacarrera.MostrarCarrera();

            Console.ReadKey();*/

            Carrera miCarrera;

            miCarrera = new Carrera();

            Auto nuevoAuto = new Auto();

            miCarrera = miCarrera + nuevoAuto;

            miCarrera = miCarrera + new Auto();

            Tiempo time = 20;
            Kilometros km = 5;

            miCarrera.correrCarrera(time);

            miCarrera.correrCarrera(km);

            Console.WriteLine(miCarrera.MostrarCarrera());

            Console.ReadKey();
        }
    }
}
