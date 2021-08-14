using FrontEndAPI.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FrontEndAPI.Controllers
{
    public class EmpleoController : Controller
    {
        private readonly IConfiguration _config;
        private string _URL;
        private ServiceRepository serviceObj;

        public EmpleoController(IConfiguration config)
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
                HttpResponseMessage response = serviceObj.GetResponse("api/empleo");
                response.EnsureSuccessStatusCode();
                var content = response.Content.ReadAsStringAsync().Result;
                List<Models.EmpleoViewModel> region = JsonConvert.DeserializeObject<List<Models.EmpleoViewModel>>(content);

                ViewBag.Title = "Empleos";
                return View(region);
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
            HttpResponseMessage response = serviceObj.GetResponse("api/empleo/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.EmpleoViewModel categoryViewModel =
                JsonConvert.DeserializeObject<Models.EmpleoViewModel>(content);
            return View(categoryViewModel);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.EmpleoViewModel empleo)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PostResponse("api/empleo", empleo);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = empleo.EmpleoID });
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/empleo/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.EmpleoViewModel EmpleoViewModel =
                JsonConvert.DeserializeObject<Models.EmpleoViewModel>(content);
            return View(EmpleoViewModel);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.EmpleoViewModel empleo)
        {
            try
            {
                HttpResponseMessage response = serviceObj.PutResponse("api/empleo", empleo);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("Details", new { id = empleo.EmpleoID });
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = serviceObj.GetResponse("api/empleo/" + id.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            Models.EmpleoViewModel EmpleoViewModel =
                JsonConvert.DeserializeObject<Models.EmpleoViewModel>(content);
            return View(EmpleoViewModel);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Models.EmpleoViewModel empleo)
        {
            try
            {
                HttpResponseMessage response = serviceObj.DeleteResponse("api/region/" + empleo.EmpleoID.ToString());
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