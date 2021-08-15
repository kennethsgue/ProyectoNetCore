using BackEnd.DAL;
using BackEnd.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
        public ActionResult Create(Empleo empleo)
        {
            using (UnidadDeTrabajo<Empleo> unidad = new UnidadDeTrabajo<Empleo>(new EmpleosContext()))
            {
                unidad.genericDAL.Add(empleo);
                unidad.Complete();
            }

            return RedirectToAction("Index");
        }

        // GET: RegistroUsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            Empleo empleo;
            using (UnidadDeTrabajo<Empleo> Unidad
               = new UnidadDeTrabajo<Empleo>(new EmpleosContext()))
            {
                empleo = Unidad.genericDAL.Get(id);
            }

            return View(empleo);
        }

        // POST: RegistroUsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Empleo empleo)
        {
            using (UnidadDeTrabajo<Empleo> unidad = new UnidadDeTrabajo<Empleo>(new EmpleosContext()))
            {
                unidad.genericDAL.Update(empleo);
                unidad.Complete();
            }

            return RedirectToAction("Index");
        }

        // GET: RegistroUsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistroUsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Empleo empleo)
        {
            using (UnidadDeTrabajo<Empleo> unidad = new UnidadDeTrabajo<Empleo>(new EmpleosContext()))
            {
                unidad.genericDAL.Remove(empleo);
                unidad.Complete();
            }
            return RedirectToAction("Index");
        }
    }
}