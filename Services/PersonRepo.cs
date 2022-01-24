using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Infrastructure;

namespace Services
{
    public class PersonRepo : IPersonRepo
    {
        private IRepository<Person> _repository;

        public PersonRepo(IRepository<Person> repository)
        {

            _repository = repository;

        }

        public IEnumerable<Person> GetAll()
        {
            return _repository.GetAll();
        }

        public Person GetById(int Id)
        {
            return _repository.GetbyID(Id);
        }
    }
}
