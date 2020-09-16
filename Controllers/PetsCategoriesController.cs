using SendenPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SendenPets.Controllers
{
    public class PetsCategoriesController : Controller
    {
        // GET: PetsCategories
        public ActionResult Details(int id)
        {
            PetsContext petsContext = new PetsContext();
            PetsCategories categories  = petsContext.petsCategories.Single(p => p.Pets_Id == id);
            return View(categories);

        }
        public ActionResult Index()
        {
            PetsContext petsContext = new PetsContext();
            List<PetsCategories> categories = petsContext.petsCategories.ToList();
            return View(categories );

        }
    }
}