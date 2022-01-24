using DomainLayer;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer
{
    public class PersonService : IPersonService
    {
        private IRepository<Person> _repository;

        public PersonService(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public void DeletePerson(int id)
        {
            Person person = GetPerson(id);
            _repository.Remove(person);
            _repository.SaveChanges();
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _repository.GetAll();
        }

        public Person GetPerson(int id)
        {
            return _repository.Get(id);
        }

        public void InsertPerson(Person person)
        {
             _repository.Insert(person);
        }

        public void UpdatePerson(Person person)
        {
            _repository.Update(person);
        }


    }
}
