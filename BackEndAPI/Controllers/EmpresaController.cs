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
    public class EmpresaController : ControllerBase
    {
        private Empresa Convertir(EmpresaModel empresa)
        {
            return new Empresa
            {
                EmpresaId = empresa.EmpresaID,
                Descripcion = empresa.Descripcion,
                NombreEmpresa = empresa.NombreEmpresa,
                Direccion = empresa.Direccion,
                Clave = empresa.Clave,
                Correo = empresa.Correo,
                CedulaJuridica = empresa.CedulaJuridica,
                Codigo = empresa.Codigo
            };
        }

        // GET: api/<EmpresaController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Empresa> empresa;
            using (UnidadDeTrabajo<Empresa> unidad = new
                UnidadDeTrabajo<Empresa>(new EmpleosContext()))
            {
                empresa = unidad.genericDAL.GetAll();
            }
            return new JsonResult(empresa);
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Empresa empresa;
            using (UnidadDeTrabajo<Empresa> unidad = new
                UnidadDeTrabajo<Empresa>(new EmpleosContext()))
            {
                empresa = unidad.genericDAL.Get(id);
            }
            return new JsonResult(empresa);
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public bool Post([FromBody] EmpresaModel empresa)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Empresa> unidad = new UnidadDeTrabajo<Empresa>(new EmpleosContext()))
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

        // PUT api/<EmpresaController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] EmpresaModel empresa)
        {
            bool result = false;
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                using (UnidadDeTrabajo<Empresa> unidad = new UnidadDeTrabajo<Empresa>(new EmpleosContext()))
                {
                    unidad.genericDAL.Update(Convertir(empresa));
                    result = unidad.Complete();
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            try
            {
                Empresa empresa;
                using (UnidadDeTrabajo<Empresa> unidad = new UnidadDeTrabajo<Empresa>(new EmpleosContext()))
                {
                    empresa = unidad.genericDAL.Get(id);
                }
                using (UnidadDeTrabajo<Empresa> unidad = new UnidadDeTrabajo<Empresa>(new EmpleosContext()))
                {
                    unidad.genericDAL.Remove(empresa);
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