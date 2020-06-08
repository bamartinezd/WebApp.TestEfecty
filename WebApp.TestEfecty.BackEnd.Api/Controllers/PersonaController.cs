using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.TestEfecty.BackEnd.Util.DTO;
using WebApp.TestEfecty.BackEnd.BL;

namespace WebApp.TestEfecty.BackEnd.Api.Controllers
{
    public class PersonaController : ApiController
    {
        // GET: api/Persona
        public List<PersonaDTO> Get()
        {
            return new PersonaBL().GetAll();
        }

        // GET: api/Persona/5
        public PersonaDTO Get(int id)
        {
            return new PersonaBL().GetById(id);
        }

        // POST: api/Persona
        public int Post([FromBody]PersonaDTO persona)
        {
            return new PersonaBL().Create(persona);
        }

        // PUT: api/Persona/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Persona/5
        public void Delete(int id)
        {
        }
    }
}
