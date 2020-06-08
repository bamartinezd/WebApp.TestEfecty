using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.TestEfecty.FrontEnd.Web.Controllers
{
    public class TipoDocController : Controller
    {
        // GET: TipoDoc
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoDoc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoDoc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDoc/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoDoc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoDoc/Edit/5
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

        // GET: TipoDoc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoDoc/Delete/5
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
