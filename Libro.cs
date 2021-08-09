using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.HomeWorkPractices.Models.Entities
{
    public class Libro : Publicacion
    {
        private int numeroPaginas;

        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        //Constructor vacio
        public Libro()
        {

        }

        //Constructor sobrecargado
        public Libro(string titulo, double precio, int numeroPaginas)
            : base(titulo, precio)
        {
            this.NumeroPaginas = numeroPaginas;
        }
    }
}
