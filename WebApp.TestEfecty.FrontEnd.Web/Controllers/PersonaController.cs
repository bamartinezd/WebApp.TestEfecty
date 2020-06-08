using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.TestEfecty.FrontEnd.Web.Models;

namespace WebApp.TestEfecty.FrontEnd.Web.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<PersonaModel> personas = null;
            RestClient restClient = new RestClient($"{ConfigurationManager.AppSettings["AddressPortAPI"]}/api/Persona");
            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("Content-Type", "application/json");
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var resp = response.Content;
                resp = resp.Trim("\"".ToCharArray());
                resp = resp.Replace("\\", "");
                personas = new List<PersonaModel>(JsonConvert.DeserializeObject<List<PersonaModel>>(resp));
            }

            return View(personas);
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {


            PersonaModel persona = null;
            RestClient restClient = new RestClient($"{ConfigurationManager.AppSettings["AddressPortAPI"]}/api/Persona/{id}");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var resp = response.Content;
                resp = resp.Trim("\"".ToCharArray());
                resp = resp.Replace("\\", "");
                persona = JsonConvert.DeserializeObject<PersonaModel>(resp);
            }

            return View(persona);
        }

        // GET: Persona/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(PersonaModel persona)
        {
            try
            {



                RestClient restClient = new RestClient($"{ConfigurationManager.AppSettings["AddressPortAPI"]}/api/Persona");
                RestRequest request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/ x-www-form-urlencoded");

                request.AddParameter("Nombres", persona.Nombres);
                request.AddParameter("Apellidos", persona.Apellidos);
                request.AddParameter("IdTipoDoc", persona.IdTipoDoc);
                request.AddParameter("FechaNac", persona.FechaNac);
                request.AddParameter("ValorGanar", persona.ValorGanar);

                var response = restClient.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return RedirectToAction("Index");
                }
                else {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
