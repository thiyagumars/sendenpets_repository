using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendenPets.Models;
namespace SendenPets.Controllers
{
    public class PetsController : Controller
    {
        // GET: Pets
        public ActionResult Details(int id)
        {
            PetsContext petsContext = new PetsContext();
            Pet pets = petsContext.Pets.Single(p => p.Pets_Id  == id);
            return View(pets);

        }
        public ActionResult Index()
        {
            PetsContext petsContext = new PetsContext();
            List<Pet> pets = petsContext.Pets.ToList();
            return View(pets);

        }
    }
}