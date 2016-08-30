using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Kilometros
    {
        public int cantidad;

        public Kilometros(int cant)
        {
            this.cantidad = cant;
        }


        //SOBRECARGA DE OPERADORES
        public static Kilometros operator +(Kilometros KmAux, int valor)
        {
            KmAux.cantidad = KmAux.cantidad + valor;
            return KmAux;
        }

        public static Kilometros operator +(Kilometros KmAux, Kilometros km)
        {
            KmAux.cantidad = KmAux.cantidad + km.cantidad;
            return KmAux;
        }

        public static Kilometros operator -(Kilometros KmAux, int valor)
        {
            KmAux.cantidad = KmAux.cantidad - valor;
            return KmAux;
        }

        public static Kilometros operator -(Kilometros KmAux, Kilometros km)
        {
            KmAux.cantidad = KmAux.cantidad - km.cantidad;
            return KmAux;
        }

        public static bool operator ==(Kilometros kmAux, int valor)
        {
            if (kmAux.cantidad == valor)
                return true;
            return false;
        }

        public static bool operator ==(Kilometros kmAux, Kilometros km)
        {
            if (kmAux.cantidad == km.cantidad)
                return true;
            return false;
        }

        public static bool operator !=(Kilometros kmAux, int valor)
        {
            if (kmAux.cantidad != valor)
                return true;
            return false;
        }

        public static bool operator !=(Kilometros kmAux, Kilometros km)
        {
            if (kmAux.cantidad != km.cantidad)
                return true;
            return false;
        }
    }
}
