using System.Collections.Generic;

namespace PersonWcfService.Models
{
    public interface IPersonRepository
    {
        List<Person> Persons { get; set; }
    }
}