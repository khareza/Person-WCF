using AspClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspClient.WcfServiceMethods
{
    public class ServiceConnection
    {
        WcfServiceProvider.PersonClient WcfService = new WcfServiceProvider.PersonClient();

        public List<Person> GetAllPersons()
        {
            var persons = WcfService.GetAllPersons();
            List<Person> personList = new List<Person>();
            foreach (var item in persons)
            {
                personList.Add(new Person() { Id = item.Id, FirstName = item.FirstName, LastName = item.LastName });
            }
            return personList;
        }

        public Person GetPersonById(int id)
        {
            var person = WcfService.GetPersonById(id);
            return new Person(){ Id = person.Id, FirstName = person.FirstName, LastName = person.LastName };
        }

        public void DeletePerson(int id)
        {
            WcfService.DeletePerson(id);
        }

        public void UpdatePerson(int id, string firstName, string lastName)
        {
            WcfService.UpdatePerson(id, firstName, lastName);
        }

        public void CreatePerson(string firstName, string lastName)
        {
            WcfService.CreatePerson(firstName, lastName);
        }
    }
}