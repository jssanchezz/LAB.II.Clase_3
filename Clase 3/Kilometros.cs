using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Kilometros
    {
        private int _cantidad;

        private Kilometros(int cant)
        {
            this._cantidad = cant;
        }


        //SOBRECARGA DE OPERADORES
        public static Kilometros operator +(Kilometros KmAux, int valor)
        {
            KmAux._cantidad = KmAux._cantidad + valor;
            return KmAux;
        }

        public static Kilometros operator +(Kilometros KmAux, Kilometros km)
        {
            KmAux._cantidad = KmAux._cantidad + km._cantidad;
            return KmAux;
        }

        public static Kilometros operator -(Kilometros KmAux, int valor)
        {
            KmAux._cantidad = KmAux._cantidad - valor;
            return KmAux;
        }

        public static Kilometros operator -(Kilometros KmAux, Kilometros km)
        {
            KmAux._cantidad = KmAux._cantidad - km._cantidad;
            return KmAux;
        }

        public static bool operator ==(Kilometros kmAux, int valor)
        {
            if (kmAux._cantidad == valor)
                return true;
            return false;
        }

        public static bool operator ==(Kilometros kmAux, Kilometros km)
        {
            if (kmAux._cantidad == km._cantidad)
                return true;
            return false;
        }

        public static bool operator !=(Kilometros kmAux, int valor)
        {
            if (kmAux._cantidad != valor)
                return true;
            return false;
        }

        public static bool operator !=(Kilometros kmAux, Kilometros km)
        {
            if (kmAux._cantidad != km._cantidad)
                return true;
            return false;
        }

        public static implicit operator Kilometros(int valor)
        {
            return new Kilometros(valor);
        }

        public static explicit operator int(Kilometros km)
        {
            return km._cantidad;
        }
    }
}
