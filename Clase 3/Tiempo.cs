using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Tiempo
    {
        private int _cantidad; //Cuando tenemos un atributo privado le colocamos un "_" para saber que es privado al momento de usarlo

        private Tiempo(int cant)
        {
            this._cantidad = cant;
        }

        //SOBRECARGA DE OPERADORES
        public static Tiempo operator +(Tiempo tiempoAux, int valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad + valor;
            return tiempoAux;
        }

        public static Tiempo operator +(Tiempo tiempoAux, Tiempo time)
        {
            tiempoAux._cantidad = tiempoAux._cantidad + time._cantidad;
            return tiempoAux;
        }

        public static Tiempo operator -(Tiempo tiempoAux, int valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad - valor;
            return tiempoAux;
        }

        public static Tiempo operator -(Tiempo tiempoAux, Tiempo time)
        {
            tiempoAux._cantidad = tiempoAux._cantidad - time._cantidad;
            return tiempoAux;
        }

        public static bool operator ==(Tiempo tiempoAux, int valor)
        {
            if (tiempoAux._cantidad == valor)
                return true;
            return false;
        }

        public static bool operator ==(Tiempo tiempoAux, Tiempo time)
        {
            if (tiempoAux._cantidad == time._cantidad)
                return true;
            return false;
        }

        public static bool operator !=(Tiempo tiempoAux, int valor)
        {
            if (tiempoAux._cantidad != valor)
                return true;
            return false;
        }

        public static bool operator !=(Tiempo tiempoAux, Tiempo time)
        {
            if (tiempoAux._cantidad != time._cantidad)
                return true;
            return false;
        }

        public static bool operator <(Tiempo tiempoAux, int valor)
        {
            if (tiempoAux._cantidad < valor)
                return true;
            return false;
        }

        public static bool operator <(Tiempo tiempoAux, Tiempo time)
        {
            if (tiempoAux._cantidad < time._cantidad)
                return true;
            return false;
        }

        public static bool operator >(Tiempo tiempoAux, int valor)
        {
            if (tiempoAux._cantidad > valor)
                return true;
            return false;
        }

        public static bool operator >(Tiempo tiempoAux, Tiempo time)
        {
            if (tiempoAux._cantidad > time._cantidad)
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

        public static explicit operator int(Tiempo time)
        {
            return time._cantidad;
        }
    }
}
