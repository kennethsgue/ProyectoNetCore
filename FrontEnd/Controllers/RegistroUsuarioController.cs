using BackEnd.DAL;
using BackEnd.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Controllers
{
    public class RegistroUsuarioController : Controller
    {
        // GET: RegistroUsuarioController
        public ActionResult Index()
        {
            List<Empleo> empleos;

            using (UnidadDeTrabajo<Empleo> Unidad
                = new UnidadDeTrabajo<Empleo>(new EmpleosContext()))
            {
                empleos = Unidad.genericDAL.GetAll().ToList();
            }
            return View(empleos);
        }

        // GET: RegistroUsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegistroUsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroUsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroUsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistroUsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroUsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistroUsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
