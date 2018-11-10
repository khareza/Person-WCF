using Microsoft.AspNetCore.Mvc;
using PersonWcfService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcfServiceProvider;
namespace PersonWcfServiceClient.Controllers
{
    public class PersonController : Controller
    {
        IPerson WcfService = new PersonClient();
        public async Task<ViewResult> Index()
        {
            var persons = await WcfService.GetAllPersonsAsync();
            return View(persons);
        }

        public async Task<ViewResult> GetPersonById(int id)
        {
            var person = await WcfService.GetPersonByIdAsync(id);
            return View("SinglePersonView", person);
        }

        public async Task<ActionResult> CreateNewPerson(string firstName, string lastName)
        {
            await WcfService.CreatePersonAsync(1, firstName, lastName);
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> UpdatePerson(int id, string firstName, string lastName)
        {
            await WcfService.UpdatePersonAsync(id,firstName,lastName);
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> DeletePerson(int id)
        {
            await WcfService.DeletePersonAsync(id);
            return RedirectToAction("Index");
        }
    }
}
