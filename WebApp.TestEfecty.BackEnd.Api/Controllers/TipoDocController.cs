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
    public class TipoDocController : ApiController
    {
        // GET: api/TipoDoc
        public List<TipoDocDTO> Get()
        {
            return new TipoDocBL().GetAll();
        }
    }
}
