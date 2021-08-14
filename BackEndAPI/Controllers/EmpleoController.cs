using BackEnd.DAL;
using BackEnd.Entities;
using BackEndAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleoController : ControllerBase
    {

        private Empleo Convertir(EmpleoModel empleo)
        {
            return new Empleo
            {
                EmpleoId = empleo.EmpleoID,
                NombreEmpleo = empleo.NombreEmpleo,
                Descripcion = empleo.Descripcion,
                Salario = empleo.Salario,
                Ubicacion = empleo.Ubicacion,
                EmpresaId = empleo.EmpresaId,
                Especializacion = empleo.Especializacion
            };
        }
        // GET: api/<EmpleoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Empleo> empleos;
            using (UnidadDeTrabajo<Empleo> unidad = new 
                UnidadDeTrabajo<Empleo>(new EmpleosContext())) {
                empleos = unidad.genericDAL.GetAll();
            }
            return new JsonResult(empleos);
        }

        // GET api/<EmpleoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Empleo empleo;
            using (UnidadDeTrabajo<Empleo> unidad = new 
                UnidadDeTrabajo<Empleo>(new EmpleosContext()))
            {
                empleo = unidad.genericDAL.Get(id);
            }
            return new JsonResult(empleo);
        }

        // POST api/<EmpleoController>
        [HttpPost]
        public bool Post([FromBody] EmpleoModel empleo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Empleo> unidad = new UnidadDeTrabajo<Empleo>(new EmpleosContext()))
                {
                    unidad.genericDAL.Add(Convertir(empleo));
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<EmpleoController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] EmpleoModel empleo)
        {
            bool result = false;
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Empleo> unidad = new UnidadDeTrabajo<Empleo>(new EmpleosContext()))
                {
                    unidad.genericDAL.Update(Convertir(empleo));
                    result = unidad.Complete();
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        // DELETE api/<EmpleoController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            try
            {
                Empleo empleo;
                using (UnidadDeTrabajo<Empleo> unidad = new UnidadDeTrabajo<Empleo>(new EmpleosContext()))
                {
                    empleo = unidad.genericDAL.Get(id);
                }
                using (UnidadDeTrabajo<Empleo> unidad = new UnidadDeTrabajo<Empleo>(new EmpleosContext()))
                {
                    unidad.genericDAL.Remove(empleo);
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
