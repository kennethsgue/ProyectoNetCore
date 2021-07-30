using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.DAL
{
    public interface IEmpleosDAL
    {
        List<Empleo> GetCategories(string CategoryName);
    }
}
