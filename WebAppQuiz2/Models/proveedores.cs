using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppQuiz2.Models
{
    public class proveedores
    {
        public int id { get; set;}
        public string codigo { get; set;}
        public string nombre { get; set;}
        public int telefono { get; set;}
        public string direccion { get; set;}
        public string descripcion { get; set;}
    }
}