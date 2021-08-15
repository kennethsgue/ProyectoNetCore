using FrontEndAPI.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FrontEndAPI.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IConfiguration _config;
        private string _URL;
        private ServiceRepository serviceObj;

        public EmpresaController(IConfiguration config)
        {
            _config = config;
            _URL = _config.GetValue<string>("Services:EmpleoURL");
            serviceObj = new ServiceRepository(_URL);
        }

        // GET: CategoryController
        public IActionResult Index()
        {
            try
            {
                HttpResponseMessage response = serviceObj.GetResponse("api/empresa");
                response.EnsureSuccessStatusCode();
                var content = response.Content.ReadAsStringAsync().Result;
                List<Models.EmpresaViewModel> empresa = JsonConvert.DeserializeObject<List<Models.EmpresaViewModel>>(content);

                ViewBag.Title = "Empresas";
                return View(empresa);
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

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/empresa/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.EmpresaViewModel empresaViewModel =
                JsonConvert.DeserializeObject<Models.EmpresaViewModel>(content);
            return View(empresaViewModel);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.EmpresaViewModel empresa)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PostResponse("api/empresa", empresa);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = empresa.EmpresaID });
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/empresa/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.EmpresaViewModel empresaViewModel =
                JsonConvert.DeserializeObject<Models.EmpresaViewModel>(content);
            return View(empresaViewModel);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.EmpresaViewModel empresa)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PutResponse("api/empresa", empresa);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = empresa.EmpresaID });
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/empresa/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.EmpresaViewModel empresaViewModel =
                JsonConvert.DeserializeObject<Models.EmpresaViewModel>(content);
            return View(empresaViewModel);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Models.EmpresaViewModel empresa)
        {
            try
            {
                HttpResponseMessage response = serviceObj.DeleteResponse("api/empresa/" + empresa.EmpresaID.ToString());
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