using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppQuiz2.Models
{
    public class articulos
    {
        public int id { get; set; }
        public string provedor { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
    }
}