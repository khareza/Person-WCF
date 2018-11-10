using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonWcfService.Models
{
    public class PersonDB : DbContext
    {
        public PersonDB() : base("PersonDB")
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}