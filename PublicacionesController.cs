using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.HomeWorkPractices.Models.Entities;

namespace WebApplication.HomeWorkPractices.Controllers
{
    public class PublicacionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Libro(string titulo, double precio, int numeroPaginas)
        {
            Libro libro = new Libro(titulo, precio ,numeroPaginas);
            //Debug.WriteLine(precio.ToString(), titulo, numeroPaginas);
            /*libro.Precio = precio;
            libro.Titulo = titulo;
            libro.NumeroPaginas = numeroPaginas;*/
            return Json(libro);
        }

        [HttpPost]
        public JsonResult CD(double precio, string titulo, int tiempoReproduccion)
        {

            CD cd= new CD(titulo, precio, tiempoReproduccion);
            //Debug.WriteLine(precio.ToString(),titulo,tiempoReproduccion);
            /*cd.Precio = precio;
            cd.Titulo = titulo;
            cd.TiempoReproduccion = tiempoReproduccion;*/
            return Json(cd);
        }

    }
}
