using BackEnd.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.DAL
{
    public class EmpleosDALImpl
    {
        private EmpleosContext context;
        public EmpleosDALImpl(EmpleosContext _context)
        {
            context = _context;
        }
        public List<Empleo> GetCategories(string CategoryName)
        {
            List<Empleo> result;


            result = context.Empleos.FromSqlRaw($"exec dbo.sp_getCategorybyName @name ={CategoryName} ")
                 .ToListAsync().Result;

            return result;


        }
    }
}
