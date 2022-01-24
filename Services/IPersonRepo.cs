using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public interface IPersonRepo
    {
        IEnumerable<Person> GetAll();

        Person GetById(int Id);

    }
}
