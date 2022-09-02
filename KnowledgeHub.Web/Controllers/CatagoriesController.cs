using KnowledgeHub.Web.Models.Data;
using KnowledgeHub.Web.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHub.Web.Controllers
{
    public class CatagoriesController : Controller
    {
        KnowledgeHubDbContext db = new KnowledgeHubDbContext();
        public IActionResult Index()
        {

            // fetch the catagory details
            List<Catagory> catagories = db.Catagories.ToList();
            //ViewBag.CatagoryData = catagories;

            //ViewData["CatagoryData"] = catagories;

            //TempData["CatagoryData"] = catagories;


            return View(catagories);
        }

        // for create
        // /Catagories/create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Catagory catagory)
        {
            // do validation
            if (!ModelState.IsValid)
                return View("Create");


            db.Catagories.Add(catagory);
            db.SaveChanges();
            TempData["Message"] = $"Catagory {catagory.Name} created successfully.";

            //return View("Index", db.Catagories.ToList());
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Catagory catagoryToDelete = db.Catagories.Find(id);
            if (catagoryToDelete == null)
            {
                return NotFound();
            }
            //db.Catagories.Remove(catagoryToDelete);
            //db.SaveChanges();
            //TempData["Message"] = $"Catagory {catagoryToDelete.Name} deleted successfully.";
            //return RedirectToAction("Index");

            return View("ConfirmDelete", catagoryToDelete);
        }

        public IActionResult ConfirmDelete(int id)
        {
            Catagory catagoryToDelete = db.Catagories.Find(id);
            db.Catagories.Remove(catagoryToDelete);
            db.SaveChanges();
            TempData["Message"] = $"Catagory {catagoryToDelete.Name} deleted successfully.";
            return RedirectToAction("Index");
        }

    }
}
