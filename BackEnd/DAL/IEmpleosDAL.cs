using BackEnd.Entities;
using System.Collections.Generic;

namespace BackEnd.DAL
{
    public interface IEmpleosDAL
    {
        List<Empleo> GetCategories(string CategoryName);
    }
}