using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Carrera
    {
        //DEPRECATED: Por colecciones
        /*public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;*/

        public List<Auto> listaDeAutos;

        private static Random randomKilometros;
        private static Random randomTiempo;

        #region Constructores

            public Carrera()
            {
                this.listaDeAutos = new List<Auto>();

                /*this.auto1 = new Auto();
                this.auto2 = new Auto();
                this.auto3 = new Auto();
                this.auto4 = new Auto();
                this.auto5 = new Auto();
                this.auto6 = new Auto();*/
                //Depreticate por colecciones
            }

            static Carrera()
            {
                randomKilometros = new Random();
                randomTiempo = new Random();
            }

        #endregion

        private bool agregarAuto(Auto unAuto)
        {
            this.listaDeAutos.Add(unAuto);
            return true;
        }

        public static Carrera operator +(Carrera carrera, Auto unAuto)
        {
            carrera.agregarAuto(unAuto);

            return carrera;
        }
        
        public void correrCarrera(Tiempo time)
        {
            int contador;
            
            for (contador = 0; contador < (int)time; contador++)
            {
                foreach (Auto unAuto in this.listaDeAutos)
                {
                    unAuto.agregar((Tiempo)randomTiempo.Next(10,100));
                }

                //DEPRECATED: Por colecciones
                /*this.auto1.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto2.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto3.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto4.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto5.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto6.agregar(timeAux = randomTiempo.Next(10, 100));*/
            }
        }

        public void correrCarrera(Kilometros km)
        {
            int contador;
            
            for (contador = 0; contador < (int)km; contador++)
            {
                foreach (Auto unAuto in this.listaDeAutos)
                {
                    unAuto.agregar((Kilometros)randomKilometros.Next(10, 100));
                }


                
                //DEPRECATED: Por colecciones
                /*this.auto1.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto2.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto3.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto4.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto5.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto6.agregar(auxKm = randomKilometros.Next(10, 100));*/
            }
        }

        public string MostrarCarrera()
        {

            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Carrera");

            foreach (Auto unAuto in this.listaDeAutos)
            {                
                sb.AppendLine(unAuto.MostrarAuto());
            }

            //DEPRICATED: Por colecciones
            /*this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();*/

            return sb.ToString();
        }
    }
}
