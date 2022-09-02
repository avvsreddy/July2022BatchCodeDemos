using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgeHub.Web.Models.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [Url]
        [Display(Name = "Article URL")]
        public string ArticleURL { get; set; }
        public string Description { get; set; }
        public Catagory Catagory { get; set; }
        [Display(Name = "Select Catagory")]
        public int CatagoryID { get; set; }
        public string PostedBy { get; set; }
        public bool IsApproved { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateSubmited { get; set; }



    }
}
