using FrontEndAPI.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FrontEndAPI.Controllers
{
    public class AplicacionController : Controller
    {
        private readonly IConfiguration _config;
        private string _URL;
        private ServiceRepository serviceObj;

        public AplicacionController(IConfiguration config)
        {
            _config = config;
            _URL = _config.GetValue<string>("Services:EmpleoURL");
            serviceObj = new ServiceRepository(_URL);
        }

        public IActionResult Index()
        {
            try
            {
                HttpResponseMessage response = serviceObj.GetResponse("api/aplicacion");
                response.EnsureSuccessStatusCode();
                var content = response.Content.ReadAsStringAsync().Result;
                List<Models.AplicacionViewModel> aplicacion = JsonConvert.DeserializeObject<List<Models.AplicacionViewModel>>(content);

                ViewBag.Title = "Aplicacion";
                return View(aplicacion);
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult Details(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/aplicacion/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.AplicacionViewModel aplicacionViewModel =
                JsonConvert.DeserializeObject<Models.AplicacionViewModel>(content);
            return View(aplicacionViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.AplicacionViewModel aplicacion)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PostResponse("api/aplicacion", aplicacion);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = aplicacion.UsuarioId });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/aplicacion/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.AplicacionViewModel aplicacionViewModel =
                JsonConvert.DeserializeObject<Models.AplicacionViewModel>(content);
            return View(aplicacionViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.AplicacionViewModel aplicacion)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PutResponse("api/aplicacion", aplicacion);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = aplicacion.UsuarioId });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/aplicacion/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.AplicacionViewModel aplicacionViewModel =
                JsonConvert.DeserializeObject<Models.AplicacionViewModel>(content);
            return View(aplicacionViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Models.AplicacionViewModel aplicacion)
        {
            try
            {
                HttpResponseMessage response = serviceObj.DeleteResponse("api/aplicacion/" + aplicacion.UsuarioId.ToString());
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}