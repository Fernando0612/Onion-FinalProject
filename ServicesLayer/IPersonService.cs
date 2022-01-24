using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAllPersons();
        Person GetPerson(int id);
        void InsertPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int id);


    }
}
