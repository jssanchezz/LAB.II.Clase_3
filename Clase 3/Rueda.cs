using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{

    /*En esta clase podemos observar la utilizacion de "sobrecarga de costructores" y la reutilizacion de codigo
    implementada en los constructores.*/

    public class Rueda
    {
        public string Marca;
        public float Tamaño;

        /// <summary>
        /// Constructor por defecto, inicializa el tamaño en 0 y marca en "sin marca".
        /// </summary>
        public Rueda() //Constructor, no lleva valor de retorno ni argumentos.
        {
            this.Marca = "Sin marca";
        }

        /// <summary>
        /// Constructor, inicializa la variable 'marca' pasada como argumento.
        /// </summary>
        /// <param name="marca">string, nombre de la marca</param>
        public Rueda(string marca)
        {
            this.Marca = marca;
        }

        /// <summary>
        /// Constructor, inicializa la variable 'tamanio' pasada como argumento.
        /// </summary>
        /// <param name="tamanio">numero entero a ser asignado a la variale tamanio.</param>
        public Rueda(int tamanio):this()
        {
            this.Tamaño = tamanio;
        }

        /// <summary>
        /// Constructor, inicializa las variables pasadas como argumento.
        /// </summary>
        /// <param name="marca">string a ser asignado a la variable 'marca'.</param>
        /// <param name="tamanio">numero entero a ser asignado a la variable 'tamanio'.</param>
        public Rueda(string marca, int tamanio):this(tamanio)
        {
            this.Marca = marca;
        }

        public Rueda(int tamanio, string marca):this(marca, tamanio)
        {
        }

        public void MostrarRueda()
        {
            Console.WriteLine("Tamanio rueda: " + this.Tamaño);
        }
    }
}
