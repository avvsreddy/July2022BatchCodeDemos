using KnowledgeHub.Web.Models.Entities;

namespace KnowledgeHub.Web.Models.Data
{
    public interface ICatagoriesRepository
    {

        void Create(Catagory catagory);
        void Update(Catagory catagory);

        Catagory GetCatagory(int id);
        List<Catagory> GetCatagories();

    }
}
