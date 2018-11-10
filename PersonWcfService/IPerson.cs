using PersonWcfService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PersonWcfService
{
    [ServiceContract]
    public interface IPerson
    {
        [OperationContract]
        void CreatePerson(string FirstName, string LastName);

        [OperationContract]
        Person GetPersonById(int id);

        [OperationContract]
        List<Person> GetAllPersons();

        [OperationContract]
        void DeletePerson(int id);

        [OperationContract]
        void UpdatePerson(int id, string FirstName, string LastName);
    }
}
