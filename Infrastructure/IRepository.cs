using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Infrastructure
{
    public interface IRepository<T> where T : Person
    {

        IEnumerable<T> GetAll();

        T GetbyID(int ID);


    }
}
