using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.HomeWorkPractices.Models.Entities
{
    public class CD : Publicacion
    {
        private int tiempoReproduccion;

        public int TiempoReproduccion
        {
            get { return tiempoReproduccion; }
            set { tiempoReproduccion = value; }
        }

        //Constructor vacio
        public CD()
        {

        }

        //Constructor sobrecargado
        public CD(string titulo, double precio, int tiempoReproduccion)
            : base(titulo, precio)
        {
            this.TiempoReproduccion = tiempoReproduccion;
        }
    }
}
