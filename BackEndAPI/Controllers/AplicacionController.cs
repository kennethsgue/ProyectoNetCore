using BackEnd.DAL;
using BackEnd.Entities;
using BackEndAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AplicacionController : ControllerBase
    {
        private Aplicacione Convertir(AplicacionesModel aplicacion)
        {
            return new Aplicacione
            {
                UsuarioId = aplicacion.UsuarioId,
                EmpleoId = aplicacion.EmpleoId
            };
        }

        // GET: api/<AplicacionController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Aplicacione> apliacion;
            using (UnidadDeTrabajo<Aplicacione> unidad = new
                UnidadDeTrabajo<Aplicacione>(new EmpleosContext()))
            {
                apliacion = unidad.genericDAL.GetAll();
            }
            return new JsonResult(apliacion);
        }

        // GET api/<AplicacionController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Aplicacione aplicacion;
            using (UnidadDeTrabajo<Aplicacione> unidad = new
                UnidadDeTrabajo<Aplicacione>(new EmpleosContext()))
            {
                aplicacion = unidad.genericDAL.Get(id);
            }
            return new JsonResult(aplicacion);
        }

        // POST api/<AplicacionController>
        [HttpPost]
        public bool Post([FromBody] AplicacionesModel apliacion)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Aplicacione> unidad = new UnidadDeTrabajo<Aplicacione>(new EmpleosContext()))
                {
                    unidad.genericDAL.Add(Convertir(apliacion));
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<AplicacionController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] AplicacionesModel aplicacion)
        {
            bool result = false;
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Aplicacione> unidad = new UnidadDeTrabajo<Aplicacione>(new EmpleosContext()))
                {
                    unidad.genericDAL.Update(Convertir(aplicacion));
                    result = unidad.Complete();
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        // DELETE api/<AplicacionController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            try
            {
                Aplicacione aplicacion;
                using (UnidadDeTrabajo<Aplicacione> unidad = new UnidadDeTrabajo<Aplicacione>(new EmpleosContext()))
                {
                    aplicacion = unidad.genericDAL.Get(id);
                }
                using (UnidadDeTrabajo<Aplicacione> unidad = new UnidadDeTrabajo<Aplicacione>(new EmpleosContext()))
                {
                    unidad.genericDAL.Remove(aplicacion);
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}