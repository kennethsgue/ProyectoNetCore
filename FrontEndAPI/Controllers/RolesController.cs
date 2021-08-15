using FrontEndAPI.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FrontEndAPI.Controllers
{
    public class RolesController : Controller
    {
        private readonly IConfiguration _config;
        private string _URL;
        private ServiceRepository serviceObj;

        public RolesController(IConfiguration config)
        {
            _config = config;
            _URL = _config.GetValue<string>("Services:EmpleoURL");
            serviceObj = new ServiceRepository(_URL);
        }

        public IActionResult Index()
        {
            try
            {
                HttpResponseMessage response = serviceObj.GetResponse("api/rol");
                response.EnsureSuccessStatusCode();
                var content = response.Content.ReadAsStringAsync().Result;
                List<Models.RolesViewModel> rol = JsonConvert.DeserializeObject<List<Models.RolesViewModel>>(content);

                ViewBag.Title = "Roles";
                return View(rol);
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
            HttpResponseMessage response = serviceObj.GetResponse("api/rol/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.RolesViewModel rolViewModel =
                JsonConvert.DeserializeObject<Models.RolesViewModel>(content);
            return View(rolViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.RolesViewModel rol)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PostResponse("api/rol", rol);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = rol.Codigo });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/rol/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.RolesViewModel usuarioViewModel =
                JsonConvert.DeserializeObject<Models.RolesViewModel>(content);
            return View(usuarioViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.RolesViewModel rol)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PutResponse("api/rol", rol);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = rol.Codigo });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/usuario/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.RolesViewModel rolViewModel =
                JsonConvert.DeserializeObject<Models.RolesViewModel>(content);
            return View(rolViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Models.RolesViewModel rol)
        {
            try
            {
                HttpResponseMessage response = serviceObj.DeleteResponse("api/usuario/" + rol.Codigo.ToString());
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