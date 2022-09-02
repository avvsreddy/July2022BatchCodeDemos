using KnowledgeHub.Web.Models.Data;
using KnowledgeHub.Web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KnowledgeHub.Web.Controllers
{
    public class ArticlesController : Controller
    {
        KnowledgeHubDbContext db = new KnowledgeHubDbContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CatagoryID = from c in db.Catagories
                                 select new SelectListItem
                                 {
                                     Text = c.Name,
                                     Value = c.CatagoryID.ToString()
                                 };
            return View();
        }
        [HttpPost]
        public IActionResult Create(Article article)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Create");
            article.DateSubmited = DateTime.Now;
            article.PostedBy = User.Identity.Name;
            article.IsApproved = false;
            db.Articles.Add(article);
            db.SaveChanges();
            TempData["Message"] = $"Article {article.Title} created successfully.";
            // send email to adminstrator
            return RedirectToAction("Create");
        }
    }
}
