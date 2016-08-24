using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Rueda
    {
        public string Marca;
        public float Tamanio;

        public Rueda() //Constructor, no lleva valor de retorno ni argumentos.
        {
            this.Marca = "Sin marca";
        }

        public void MostrarRueda()
        {
            Console.WriteLine("Tamanio rueda: " + this.Tamanio);
        }
    }
}
