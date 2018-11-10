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
        private EFPersonRepository db = new EFPersonRepository();
        
        public void CreatePerson(string firstName, string lastName)
        {
            db.CreatePerson(firstName, firstName);
        }

        public void DeletePerson(int id)
        {
            db.RemovePerson(id);
        }


        public List<Person> GetAllPersons()
        {
            return db.Persons.ToList();
        }

        public Person GetPersonById(int id)
        {
            return db.Persons.Where(p => p.Id == id).FirstOrDefault();
        }

        public void UpdatePerson(int id, string FirstName, string LastName)
        {
            db.UpdatePerson(id, FirstName, LastName);
        }
    }
}
