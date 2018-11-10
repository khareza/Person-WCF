using AspClient.Models;
using AspClient.WcfServiceMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspClient.Controllers
{
    public class PersonController : Controller
    {
        ServiceConnection service = new ServiceConnection();
        // GET: Person
        public ViewResult Index()
        {
            var personList = service.GetAllPersons();
            return View(personList);
        }

        public ViewResult GetPersonById(int id)
        {
            var person = service.GetPersonById(id);
            return View("SinglePerson", person);
        }

        public ActionResult CreateNewPerson(string firstName, string lastName)
        {
            service.CreatePerson(firstName, lastName);
            return RedirectToAction("Index");
        }
        public ActionResult UpdatePerson(int id, string firstName, string lastName)
        {
            service.UpdatePerson(id, firstName, lastName);
            return RedirectToAction("Index");
        }
        public ActionResult DeletePerson(int id)
        {
            service.DeletePerson(id);
            return RedirectToAction("Index");
        }
    }
}