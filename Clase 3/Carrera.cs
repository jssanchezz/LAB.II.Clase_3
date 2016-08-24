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
        }

        public void PorTiempo(int minutos)
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

        public void MostrarResultadosCarrera()
        {

        }

        public void MostrarCarrera()
        {
            this.PorTiempo(5);
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();
        }
    }
}
