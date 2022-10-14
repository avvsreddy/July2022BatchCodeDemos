using KnowledgeHub.Web.Models.Data;
using KnowledgeHub.Web.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KnowledgeHub.Web.Controllers
{
    public class ArticlesController : Controller
    {
        KnowledgeHubDbContext db = null;

        public ArticlesController(KnowledgeHubDbContext db)
        {
            this.db = db;
        }


        [HttpGet]
        [Authorize]
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
        [Authorize]
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
