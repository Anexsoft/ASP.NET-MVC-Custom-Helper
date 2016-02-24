using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomHtmlHelper.Models
{
    public class Pais
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        public static List<Pais> GetAll()
        {
            return new List<Pais>
            {
                new Pais { id = 1, Nombre = "Perú"},
                new Pais { id = 2, Nombre = "Argentina"},
                new Pais { id = 3, Nombre = "México"},
                new Pais { id = 4, Nombre = "Colombia"}
            };
        }
    }
}