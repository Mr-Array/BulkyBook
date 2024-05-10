using System.ComponentModel.DataAnnotations;

namespace BulkyBookWebMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime DataTimeCreated { get; set; }   = DateTime.Now;

    }
}
