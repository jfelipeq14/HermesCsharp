using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HermesCsharp.Models;
using HermesCsharp.Models.DTO;

namespace HermesCsharp.Controllers.RolController
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {
            List<Rol> listRol;

            using (RelationContext context = new RelationContext())
            {
                listRol = (from r in context.rol
                           select new Rol()
                           {
                               idRol = r.idRol,
                               nombreRol = r.nombreRol,
                               estadoRol = r.estadoRol
                           }).ToList();
            }

            // Verifica que los datos se obtienen correctamente
            if (listRol == null || !listRol.Any())
            {
                // Maneja el caso en que no se obtienen datos
                ViewBag.Message = "No se encontraron roles.";
            }

            return View(listRol);
        }

        // GET: Rol/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rol/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rol/Create
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

        // GET: Rol/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rol/Edit/5
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

        // GET: Rol/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rol/Delete/5
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
