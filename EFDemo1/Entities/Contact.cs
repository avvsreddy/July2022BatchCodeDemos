using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo1.Entities
{
    [Table("tbl_contacts")]
    public class Contact
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContactID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "VARCHAR")]
        public string Location { get; set; }
        [MaxLength(6)]
        public string Gender { get; set; }

        [NotMapped]
        public string SceretCode { get; set; }

        // entityframeworktutorials.com


    }
}
