using FrontEndAPI.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FrontEndAPI.Controllers
{
    public class FiltrosController : Controller
    {
        private readonly IConfiguration _config;
        private string _URL;
        private ServiceRepository serviceObj;

        public FiltrosController(IConfiguration config)
        {
            _config = config;
            _URL = _config.GetValue<string>("Services:EmpleoURL");
            serviceObj = new ServiceRepository(_URL);
        }

        public IActionResult Index()
        {
            try
            {
                HttpResponseMessage response = serviceObj.GetResponse("api/filtro");
                response.EnsureSuccessStatusCode();
                var content = response.Content.ReadAsStringAsync().Result;
                List<Models.FiltrosViewModel> empleo = JsonConvert.DeserializeObject<List<Models.FiltrosViewModel>>(content);

                ViewBag.Title = "Filtros";
                return View(empleo);
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
            HttpResponseMessage response = serviceObj.GetResponse("api/filtro/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.FiltrosViewModel filtroViewModel =
                JsonConvert.DeserializeObject<Models.FiltrosViewModel>(content);
            return View(filtroViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.FiltrosViewModel filtro)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PostResponse("api/filtro", filtro);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = filtro.Especializacion });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/filtro/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.FiltrosViewModel filtroViewModel =
                JsonConvert.DeserializeObject<Models.FiltrosViewModel>(content);
            return View(filtroViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.FiltrosViewModel filtro)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PutResponse("api/filtro", filtro);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = filtro.Especializacion });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/filtro/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.FiltrosViewModel usuarioViewModel =
                JsonConvert.DeserializeObject<Models.FiltrosViewModel>(content);
            return View(usuarioViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Models.FiltrosViewModel filtro)
        {
            try
            {
                HttpResponseMessage response = serviceObj.DeleteResponse("api/filtro/" + filtro.Especializacion.ToString());
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