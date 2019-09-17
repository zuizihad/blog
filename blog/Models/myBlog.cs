using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace blog.Models{
    public class myBlog{
        [Key]
        public int blogId { get; set; }
        [Required]
        public string blogTitle { get; set; }
        public string imagePath { get; set; }
        [Required, DataType(DataType.Html)]
        public string blogDescription { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime blogDateTime { get; set; }
        [Required]
        public bool isPublished { get; set; }
        [Required]
        public BlogCategory blogCategory { get; set; }
        public List<Comments> blogComments { get; set; }
        
    }
}