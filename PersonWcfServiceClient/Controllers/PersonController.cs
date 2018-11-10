using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonWcfServiceClient.Controllers
{
    public class PersonController : Controller
    {

        public ViewResult Index()
        {
            return View();
        }


        public ViewResult GetPersonById(int id)
        {

            return View("SinglePersonView");
        }

        public ActionResult CreateNewPerson(string firstName, string lastName)
        {
            return RedirectToAction("Index");
        }
        public ActionResult UpdatePerson(int id, string firstName, string lastName)
        {
            return RedirectToAction("Index");
        }
        public ActionResult DeletePerson(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
