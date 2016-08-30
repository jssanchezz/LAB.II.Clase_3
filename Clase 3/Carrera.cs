using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;

        private static Random randomKilometros;
        private static Random randomTiempo;
        
        public Carrera()
        {
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
        }

        static Carrera()
        {
            randomKilometros = new Random();
            randomTiempo = new Random();
        }

        /*public void PorTiempo(int minutos)
        {
            int contador;
            
            for (contador = 0; contador < minutos; contador++)
            {
                this.auto1.agregarKilometro(randomKilometros.Next(0, 100));
                this.auto2.agregarKilometro(randomKilometros.Next(0, 100));
                this.auto3.agregarKilometro(randomKilometros.Next(0, 100));
                this.auto4.agregarKilometro(randomKilometros.Next(0, 100));
                this.auto5.agregarKilometro(randomKilometros.Next(0, 100));
                this.auto6.agregarKilometro(randomKilometros.Next(0, 100));
            }

            
        }

        public void correrCarrera(Kilometros km)
        {
            int contador;

            for (contador = 0 ; contador < km.cantidad ; contador ++)
            {
                this.auto1.agregarKilometro(randomKilometros.Next(10,100));
                this.auto2.agregarKilometro(randomKilometros.Next(10,100));
                this.auto3.agregarKilometro(randomKilometros.Next(10,100));
                this.auto4.agregarKilometro(randomKilometros.Next(10,100));
                this.auto5.agregarKilometro(randomKilometros.Next(10,100));
                this.auto6.agregarKilometro(randomKilometros.Next(10,100));
            }

        }

        public void correrCarrera(Tiempo time)
        {
            int contador;
            
            for( contador = 0; contador < time.cantidad ; contador++)
            {
                this.auto1.agregarTiempo(randomTiempo.Next(10,100));
                this.auto2.agregarTiempo(randomTiempo.Next(10,100));
                this.auto3.agregarTiempo(randomTiempo.Next(10,100));
                this.auto4.agregarTiempo(randomTiempo.Next(10,100));
                this.auto5.agregarTiempo(randomTiempo.Next(10,100));
                this.auto6.agregarTiempo(randomTiempo.Next(10,100));
            }
        }*/

        public void correrCarrera(Tiempo time)
        {
            int contador;
            Tiempo timeAux = 0;

            for (contador = 0; contador < (int)time; contador++)
            {
                this.auto1.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto2.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto3.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto4.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto5.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto6.agregar(timeAux = randomTiempo.Next(10, 100));
            }
            this.MostrarCarrera();
        }

        public void correrCarrera(Kilometros km)
        {
            int contador;
            Kilometros auxKm = 0;

            for (contador = 0; contador < (int)km; contador++)
            {
                this.auto1.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto2.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto3.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto4.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto5.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto6.agregar(auxKm = randomKilometros.Next(10, 100));
            }
            this.MostrarCarrera();
        }

        public void MostrarCarrera()
        {
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();
        }
    }
}
