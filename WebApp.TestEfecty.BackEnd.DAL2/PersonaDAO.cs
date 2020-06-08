using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.TestEfecty.BackEnd.DAL
{
    public class PersonaDAO
    {
        public int IdPersona { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string IdTipoDoc { get; set; }
        public DateTime FechaNac { get; set; }
        public decimal ValorGanar { get; set; }
    }
}
