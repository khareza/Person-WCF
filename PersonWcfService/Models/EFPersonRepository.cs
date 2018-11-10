using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonWcfService.Models
{
    public class EFPersonRepository
    {
        private PersonDB _context = new PersonDB();

        public IEnumerable<Person> Persons => _context.Persons;
        public void CreatePerson(string firstName, string lastName)
        {
            
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                _context.Persons.Add(new Person() { FirstName = firstName, LastName = lastName });
                _context.SaveChanges();
            }

        }

        public void RemovePerson(int id)
        {
            var person = _context.Persons.Where(p => p.Id == id).FirstOrDefault();
            if (person != null)
            {
                _context.Persons.Remove(person);
                _context.SaveChanges();
            }

        }
        public void UpdatePerson(int id, string firstName, string lastName)
        {

            var person = _context.Persons.Where(p => p.Id == id).FirstOrDefault();
            if (person != null)
            {
                person.FirstName = firstName;
                person.LastName = lastName;
                _context.SaveChanges();
            }

        }
        public void SaveDatabase()
        {
            _context.SaveChanges();
        }
    }
}