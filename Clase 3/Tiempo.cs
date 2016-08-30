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


        //SOBRECARGA DE OPERADORES
        public static Tiempo operator +(Tiempo tiempoAux, int valor)
        {
            tiempoAux.cantidad = tiempoAux.cantidad + valor;
            return tiempoAux;
        }

        public static Tiempo operator +(Tiempo tiempoAux, Tiempo time)
        {
            tiempoAux.cantidad = tiempoAux.cantidad + time.cantidad;
            return tiempoAux;
        }

        public static Tiempo operator -(Tiempo tiempoAux, int valor)
        {
            tiempoAux.cantidad = tiempoAux.cantidad - valor;
            return tiempoAux;
        }

        public static Tiempo operator -(Tiempo tiempoAux, Tiempo time)
        {
            tiempoAux.cantidad = tiempoAux.cantidad - time.cantidad;
            return tiempoAux;
        }

        public static bool operator ==(Tiempo tiempoAux, int valor)
        {
            if (tiempoAux.cantidad == valor)
                return true;
            return false;
        }

        public static bool operator ==(Tiempo tiempoAux, Tiempo time)
        {
            if (tiempoAux.cantidad == time.cantidad)
                return true;
            return false;
        }

        public static bool operator !=(Tiempo tiempoAux, int valor)
        {
            if (tiempoAux.cantidad != valor)
                return true;
            return false;
        }

        public static bool operator !=(Tiempo tiempoAux, Tiempo time)
        {
            if (tiempoAux.cantidad != time.cantidad)
                return true;
            return false;
        }

        //Como parsear un entero a objeto
        //Existe la forma IMPLICIT y EXPLICIT
        //IMPLICIT contiene la forma EXPLICIT, es decir que si la sobrecarga es IMPLICITA, tambien podemos utilizar la explicita
        //Ej. del siguente metodo: Tiempo time; - time = 33; (IMPLICITA)
        //Tiempo time; - time =(Tiempo) 33; (EXPLICITA)
        public static implicit operator Tiempo(int valor)
        {
            return new Tiempo(valor);
        }
    }
}
