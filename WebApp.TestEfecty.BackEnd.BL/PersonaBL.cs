using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.TestEfecty.BackEnd.DAL;
using WebApp.TestEfecty.BackEnd.Util.DTO;
using WebApp.TestEfecty.BackEnd.DAL.Repositories;

namespace WebApp.TestEfecty.BackEnd.BL
{
    public class PersonaBL
    {
        public List<PersonaDTO> GetAll()
        {
            List<PersonaDTO> personaDTOs = new List<PersonaDTO>();
            List<PersonaDAO> personaDAOs = new PersonaRepository().GetAll();
            foreach (var personaDAO in personaDAOs)
            {
                PersonaDTO personaDTO = new PersonaDTO
                {
                    IdPersona = personaDAO.IdPersona,
                    Nombres = personaDAO.Nombres,
                    Apellidos = personaDAO.Apellidos,
                    FechaNac = personaDAO.FechaNac,
                    IdTipoDoc = personaDAO.IdTipoDoc,
                    ValorGanar = personaDAO.ValorGanar
                };
                personaDTOs.Add(personaDTO);
            }
            return personaDTOs;
        }

        public PersonaDTO GetById(int id)
        {
            PersonaDAO personaDAO = new PersonaRepository().GetById(id);
            PersonaDTO personaDTO = new PersonaDTO
            {
                IdPersona = personaDAO.IdPersona,
                Nombres = personaDAO.Nombres,
                Apellidos = personaDAO.Apellidos,
                FechaNac = personaDAO.FechaNac,
                IdTipoDoc = personaDAO.IdTipoDoc,
                ValorGanar = personaDAO.ValorGanar
            };
            return personaDTO;
        }

        public int Create(PersonaDTO persona)
        {
            PersonaDAO personaDAO = new PersonaDAO {
                IdPersona = persona.IdPersona,
                Nombres = persona.Nombres,
                Apellidos = persona.Apellidos,
                FechaNac = persona.FechaNac,
                IdTipoDoc = persona.IdTipoDoc,
                ValorGanar = persona.ValorGanar
            };
            int affected = new PersonaRepository().Create(personaDAO);
            return affected;
        }
    }
}
