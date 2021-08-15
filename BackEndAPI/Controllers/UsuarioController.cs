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
    public class UsuarioController : ControllerBase
    {
        private Usuario Convertir(UsuarioModel usuario)
        {
            return new Usuario
            {
                UsuarioId = usuario.UsuarioId,
                Nombre = usuario.Nombre,
                Apellidos = usuario.Apellidos,
                Cedula = usuario.Cedula,
                Correo = usuario.Correo,
                Telefono = usuario.Telefono,
                Direccion = usuario.Direccion,
                Clave = usuario.Clave,
                Cv = usuario.Cv
            };
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Usuario> usuario;
            using (UnidadDeTrabajo<Usuario> unidad = new
                UnidadDeTrabajo<Usuario>(new EmpleosContext()))
            {
                usuario = unidad.genericDAL.GetAll();
            }
            return new JsonResult(usuario);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Usuario usuario;
            using (UnidadDeTrabajo<Usuario> unidad = new
                UnidadDeTrabajo<Usuario>(new EmpleosContext()))
            {
                usuario = unidad.genericDAL.Get(id);
            }
            return new JsonResult(usuario);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public bool Post([FromBody] UsuarioModel empresa)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(new EmpleosContext()))
                {
                    unidad.genericDAL.Add(Convertir(empresa));
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] UsuarioModel usuario)
        {
            bool result = false;
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(new EmpleosContext()))
                {
                    unidad.genericDAL.Update(Convertir(usuario));
                    result = unidad.Complete();
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            try
            {
                Usuario usuario;
                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(new EmpleosContext()))
                {
                    usuario = unidad.genericDAL.Get(id);
                }
                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(new EmpleosContext()))
                {
                    unidad.genericDAL.Remove(usuario);
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