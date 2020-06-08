using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.TestEfecty.BackEnd.Util.DTO
{
    public class PersonaDTO
    {
        public int IdPersona { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string IdTipoDoc { get; set; }
        public DateTime FechaNac { get; set; }
        public decimal ValorGanar { get; set; }
    }
}
