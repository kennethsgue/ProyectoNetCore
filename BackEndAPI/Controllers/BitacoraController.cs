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
    public class BitacoraController : ControllerBase
    {
        private Bitacora Convertir(BitacoraModel bitacora)
        {
            return new Bitacora
            {
                UsuarioId = bitacora.UsuarioId,
                Fecha = bitacora.Fecha,
                Error = bitacora.Error
            };
        }

        // GET: api/<BitacoraController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Bitacora> bitacora;
            using (UnidadDeTrabajo<Bitacora> unidad = new
                UnidadDeTrabajo<Bitacora>(new EmpleosContext()))
            {
                bitacora = unidad.genericDAL.GetAll();
            }
            return new JsonResult(bitacora);
        }

        // GET api/<BitacoraController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Bitacora bitacora;
            using (UnidadDeTrabajo<Bitacora> unidad = new
                UnidadDeTrabajo<Bitacora>(new EmpleosContext()))
            {
                bitacora = unidad.genericDAL.Get(id);
            }
            return new JsonResult(bitacora);
        }

        // POST api/<BitacoraController>
        [HttpPost]
        public bool Post([FromBody] BitacoraModel bitacora)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Bitacora> unidad = new UnidadDeTrabajo<Bitacora>(new EmpleosContext()))
                {
                    unidad.genericDAL.Add(Convertir(bitacora));
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<BitacoraController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] BitacoraModel bitacora)
        {
            bool result = false;
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Bitacora> unidad = new UnidadDeTrabajo<Bitacora>(new EmpleosContext()))
                {
                    unidad.genericDAL.Update(Convertir(bitacora));
                    result = unidad.Complete();
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        // DELETE api/<BitacoraController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            try
            {
                Bitacora bitacora;
                using (UnidadDeTrabajo<Bitacora> unidad = new UnidadDeTrabajo<Bitacora>(new EmpleosContext()))
                {
                    bitacora = unidad.genericDAL.Get(id);
                }
                using (UnidadDeTrabajo<Bitacora> unidad = new UnidadDeTrabajo<Bitacora>(new EmpleosContext()))
                {
                    unidad.genericDAL.Remove(bitacora);
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