using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Tiempo
    {
        public int cantidad;

        public Tiempo(int cant)
        {
            this.cantidad = cant;
        }
        public static Tiempo operator +(Tiempo tiempoAux, int valor)
        {
            tiempoAux.cantidad = tiempoAux.cantidad + valor;
            return tiempoAux;
        }
    }
}
