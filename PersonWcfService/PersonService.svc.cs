using PersonWcfService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PersonWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PersonService.svc or PersonService.svc.cs at the Solution Explorer and start debugging.
    public class PersonService : IPerson
    {
        private List<Person> db = PersonRepository.Persons;
        
        public void CreatePerson(int id, string FirstName, string LastName)
        {
            PersonRepository.Create(id, FirstName, LastName);
        }

        public void DeletePerson(int id)
        {
            PersonRepository.Delete(id);
        }


        public List<Person> GetAllPersons()
        {
            return db;
        }

        public Person GetPersonById(int id)
        {
            return db.Where(p => p.Id == id).FirstOrDefault();
        }

        public void UpdatePerson(int id, string FirstName, string LastName)
        {
            PersonRepository.Update(id, FirstName, LastName);
        }
    }
}
