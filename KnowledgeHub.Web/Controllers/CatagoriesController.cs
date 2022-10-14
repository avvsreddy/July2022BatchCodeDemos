using KnowledgeHub.Web.Models.Data;
using KnowledgeHub.Web.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHub.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class CatagoriesController : Controller
    {
        private ICatagoriesRepository db = null;
        public CatagoriesController(ICatagoriesRepository db)
        {
            this.db = db;
        }

        public IActionResult Index(string searchValue)
        {
            List<Catagory> catagories = null;

            //db.Catagories.Remove();

            // fetch the catagory details with filter
            if (searchValue != null && searchValue.Length != 0)
            {
                catagories = (from c in db.GetCatagories()
                              where c.Name.Contains(searchValue) || c.Description.Contains(searchValue)
                              select c).ToList();
            }
            else
                catagories = db.GetCatagories();
            //ViewBag.CatagoryData = catagories;

            //ViewData["CatagoryData"] = catagories;

            //TempData["CatagoryData"] = catagories;


            return View(catagories);
        }

        // for create
        // /Catagories/create
        [HttpGet]
        //[Authorize]
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


            //db.Catagories.Add(catagory);
            //db.SaveChanges();
            db.Create(catagory);
            TempData["Message"] = $"Catagory {catagory.Name} created successfully.";

            //return View("Index", db.Catagories.ToList());
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            //Catagory catagoryToDelete = db.Catagories.Find(id);
            Catagory catagoryToDelete = db.GetCatagory(id);
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
            //Catagory catagoryToDelete = db.Catagories.Find(id);
            //db.Catagories.Remove(catagoryToDelete);
            //db.SaveChanges();
            //TempData["Message"] = $"Catagory {catagoryToDelete.Name} deleted successfully.";
            //return RedirectToAction("Index");
            return BadRequest("Delete operation is not allowed");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Catagory catagoryToEdit = db.GetCatagory(id);//db.Catagories.Find(id);
            if (catagoryToEdit == null)
                return NotFound();

            return View(catagoryToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Catagory editedCatagory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            //db.Entry(editedCatagory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //db.SaveChanges();
            db.Update(editedCatagory);
            TempData["Message"] = $"Catagory {editedCatagory.Name} updated successfully.";
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public IActionResult Hello()
        {
            return View();
        }

    }
}
