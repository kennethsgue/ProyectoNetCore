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
    public class RolController : ControllerBase
    {
        private Role Convertir(RolesModel rol)
        {
            return new Role
            {
                Codigo = rol.Codigo,
                Descripcion = rol.Descripcion
            };
        }

        // GET: api/<RolController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Role> rol;
            using (UnidadDeTrabajo<Role> unidad = new
                UnidadDeTrabajo<Role>(new EmpleosContext()))
            {
                rol = unidad.genericDAL.GetAll();
            }
            return new JsonResult(rol);
        }

        // GET api/<RolController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Role rol;
            using (UnidadDeTrabajo<Role> unidad = new
                UnidadDeTrabajo<Role>(new EmpleosContext()))
            {
                rol = unidad.genericDAL.Get(id);
            }
            return new JsonResult(rol);
        }

        // POST api/<RolController>
        [HttpPost]
        public bool Post([FromBody] RolesModel rol)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Role> unidad = new UnidadDeTrabajo<Role>(new EmpleosContext()))
                {
                    unidad.genericDAL.Add(Convertir(rol));
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<RolController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] RolesModel rol)
        {
            bool result = false;
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Role> unidad = new UnidadDeTrabajo<Role>(new EmpleosContext()))
                {
                    unidad.genericDAL.Update(Convertir(rol));
                    result = unidad.Complete();
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        // DELETE api/<RolController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            try
            {
                Role rol;
                using (UnidadDeTrabajo<Role> unidad = new UnidadDeTrabajo<Role>(new EmpleosContext()))
                {
                    rol = unidad.genericDAL.Get(id);
                }
                using (UnidadDeTrabajo<Role> unidad = new UnidadDeTrabajo<Role>(new EmpleosContext()))
                {
                    unidad.genericDAL.Remove(rol);
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