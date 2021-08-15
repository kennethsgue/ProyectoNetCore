using FrontEndAPI.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FrontEndAPI.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IConfiguration _config;
        private string _URL;
        private ServiceRepository serviceObj;

        public UsuarioController(IConfiguration config)
        {
            _config = config;
            _URL = _config.GetValue<string>("Services:EmpleoURL");
            serviceObj = new ServiceRepository(_URL);
        }

        public IActionResult Index()
        {
            try
            {
                HttpResponseMessage response = serviceObj.GetResponse("api/usuario");
                response.EnsureSuccessStatusCode();
                var content = response.Content.ReadAsStringAsync().Result;
                List<Models.UsuarioViewModel> empleo = JsonConvert.DeserializeObject<List<Models.UsuarioViewModel>>(content);

                ViewBag.Title = "Usuarios";
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
            HttpResponseMessage response = serviceObj.GetResponse("api/usuario/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.UsuarioViewModel usuarioViewModel =
                JsonConvert.DeserializeObject<Models.UsuarioViewModel>(content);
            return View(usuarioViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.UsuarioViewModel usuario)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PostResponse("api/usuario", usuario);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = usuario.UsuarioId });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/usuario/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.UsuarioViewModel usuarioViewModel =
                JsonConvert.DeserializeObject<Models.UsuarioViewModel>(content);
            return View(usuarioViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.UsuarioViewModel usuario)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PutResponse("api/usuario", usuario);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = usuario.UsuarioId });
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
            Models.UsuarioViewModel usuarioViewModel =
                JsonConvert.DeserializeObject<Models.UsuarioViewModel>(content);
            return View(usuarioViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Models.UsuarioViewModel usuario)
        {
            try
            {
                HttpResponseMessage response = serviceObj.DeleteResponse("api/usuario/" + usuario.UsuarioId.ToString());
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