using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonWcfService.Models
{
    public class PersonRepository
    {
        public static List<Person> Persons = new List<Person>()
        {
            new Person(){Id = 1, FirstName = "Kamil", LastName = "Hareza"},
            new Person(){Id = 2, FirstName = "Steve", LastName = "Smith"}
        };

        public static void Update(int id, string firstName, string lastName)
        {
            int index = Persons.FindIndex(p => p.Id == id);
            Persons[index].FirstName = firstName;
            Persons[index].LastName = lastName;
        }

        public static void Create(int id, string firstName, string lastName)
        {
            Persons.Add(new Person() { Id = id, FirstName = firstName, LastName = lastName });
        }

        public static void Delete(int id)
        {
            int index = Persons.FindIndex(p => p.Id == id);
            Persons.RemoveAt(index);
        }
    }
}