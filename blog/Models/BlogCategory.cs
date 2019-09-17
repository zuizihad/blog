using System.ComponentModel.DataAnnotations;
namespace blog.Models{
    public class BlogCategory{
        [Key]
        public int categoryId { get; set; }
        [Required, MinLength(3)]
        public string categoryName { get; set; }
    }
}