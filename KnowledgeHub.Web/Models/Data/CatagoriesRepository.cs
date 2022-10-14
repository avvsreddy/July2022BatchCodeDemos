using KnowledgeHub.Web.Models.Entities;

namespace KnowledgeHub.Web.Models.Data
{
    public class CatagoriesRepository : ICatagoriesRepository
    {
        private KnowledgeHubDbContext db = new KnowledgeHubDbContext();
        public void Create(Catagory catagory)
        {
            db.Catagories.Add(catagory);
            db.SaveChanges();

        }

        public List<Catagory> GetCatagories()
        {
            return db.Catagories.ToList();
        }

        public Catagory GetCatagory(int id)
        {
            return db.Catagories.Find(id);
        }

        public void Update(Catagory catagory)
        {
            db.Entry(catagory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
