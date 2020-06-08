using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.TestEfecty.FrontEnd.Web.Models
{
    public class PersonaModel
    {
        public int IdPersona { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string IdTipoDoc { get; set; }
        public DateTime FechaNac { get; set; }
        public decimal ValorGanar { get; set; }
    }
}