using System;
using System.ComponentModel.DataAnnotations;

namespace blog.Models{
    public class Comments{
        [Key]
        public int authorId { get; set; }
        [Required]
        public string commentAuthor { get; set; }
        [DataType(DataType.Date)]
        public DateTime commentDate { get; set; }

        public bool isHidden { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string commentAuthorEmail { get; set; }
        [Required]
        public string commentDescription { get; set; }
        public myBlog blog { get; set; } 
    }
}