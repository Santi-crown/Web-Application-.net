using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.HomeWorkPractices.Models.Entities
{
    public class Publicacion
    {
        private string titulo;
        private double precio;
        [Required(ErrorMessage = "El valor del precio deben ser solo numeros")]
        [Display(Name = "Precio del libro")]
        [Range(0, double.MaxValue, ErrorMessage ="Value for {0} must been {1} and {2}")]



        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        //Constructor vacio
        public Publicacion()
        {

        }

        //Constructor sobre cargado
        public Publicacion(string titulo, double precio)
        {
            this.Titulo = titulo;
            this.Precio = precio;
        }
    }
}
