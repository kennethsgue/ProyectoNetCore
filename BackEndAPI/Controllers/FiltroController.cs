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
    public class FiltroController : ControllerBase
    {
        private Filtro Convertir(FiltrosModel filtro)
        {
            return new Filtro
            {
                Especializacion = filtro.Especializacion,
                Cedula = filtro.Cedula,
                Nombre = filtro.Nombre
            };
        }

        // GET: api/<FiltroController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Filtro> filtro;
            using (UnidadDeTrabajo<Filtro> unidad = new
                UnidadDeTrabajo<Filtro>(new EmpleosContext()))
            {
                filtro = unidad.genericDAL.GetAll();
            }
            return new JsonResult(filtro);
        }

        // GET api/<FiltroController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Filtro filtro;
            using (UnidadDeTrabajo<Filtro> unidad = new
                UnidadDeTrabajo<Filtro>(new EmpleosContext()))
            {
                filtro = unidad.genericDAL.Get(id);
            }
            return new JsonResult(filtro);
        }

        // POST api/<FiltroController>
        [HttpPost]
        public bool Post([FromBody] FiltrosModel filtro)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Filtro> unidad = new UnidadDeTrabajo<Filtro>(new EmpleosContext()))
                {
                    unidad.genericDAL.Add(Convertir(filtro));
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<FiltroController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] FiltrosModel filtro)
        {
            bool result = false;
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Filtro> unidad = new UnidadDeTrabajo<Filtro>(new EmpleosContext()))
                {
                    unidad.genericDAL.Update(Convertir(filtro));
                    result = unidad.Complete();
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        // DELETE api/<FiltroController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            try
            {
                Filtro filtro;
                using (UnidadDeTrabajo<Filtro> unidad = new UnidadDeTrabajo<Filtro>(new EmpleosContext()))
                {
                    filtro = unidad.genericDAL.Get(id);
                }
                using (UnidadDeTrabajo<Filtro> unidad = new UnidadDeTrabajo<Filtro>(new EmpleosContext()))
                {
                    unidad.genericDAL.Remove(filtro);
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