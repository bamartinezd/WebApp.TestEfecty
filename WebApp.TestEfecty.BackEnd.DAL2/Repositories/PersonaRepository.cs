using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WebApp.TestEfecty.BackEnd.DAL.Repositories
{
    public class PersonaRepository
    {
        public List<PersonaDAO> GetAll()
        {
            List<PersonaDAO> personaDAOs = new List<PersonaDAO>();
            DataTable tab = new Cnx().ExecuteReader("select * from Persona");
            foreach (DataRow row in tab.Rows)
            {
                PersonaDAO tipoDoc = new PersonaDAO
                {
                    IdPersona = Convert.ToInt32(row["IdPersona"]),
                    Nombres = row["Nombres"].ToString(),
                    Apellidos = row["Apellidos"].ToString(),
                    FechaNac = (DateTime) row["FechaNac"],
                    IdTipoDoc = row["IdTipoDoc"].ToString(),
                    ValorGanar = Convert.ToDecimal(row["ValorGanar"])
                };
                personaDAOs.Add(tipoDoc);
            }
            return personaDAOs;
        }

        public PersonaDAO GetById(int id)
        {
            List<PersonaDAO> personaDAOs = new List<PersonaDAO>();
            DataTable tab = new Cnx().ExecuteReader($"select * from Persona where IdPersona={id}");
            foreach (DataRow row in tab.Rows)
            {
                PersonaDAO tipoDoc = new PersonaDAO
                {
                    IdPersona = Convert.ToInt32(row["IdPersona"]),
                    Nombres = row["Nombres"].ToString(),
                    Apellidos = row["Apellidos"].ToString(),
                    FechaNac = (DateTime)row["FechaNac"],
                    IdTipoDoc = row["IdTipoDoc"].ToString(),
                    ValorGanar = Convert.ToDecimal(row["ValorGanar"])
                };
                personaDAOs.Add(tipoDoc);
            }
            return personaDAOs.FirstOrDefault();
        }

        public int Create(PersonaDAO persona) {
            int affected = new Cnx().Execute($"insert into Persona (Nombres,Apellidos,IdTipoDoc,FechaNac,ValorGanar)" +
                $"values('{persona.Nombres}', '{persona.Apellidos}', '{persona.IdTipoDoc}', '{persona.FechaNac.ToString("yyyy-MM-dd")}','{persona.ValorGanar}')");
            return affected;
        }


    }
}
