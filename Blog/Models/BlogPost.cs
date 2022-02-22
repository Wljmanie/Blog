using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class BlogPost
    {
        //-- Keys --//
        public int Id { get; set; }
        public string AuthorId { get; set; }
        public int BlogId { get; set; }
        public int BlogPostStatusId { get; set; }
        
        //-- Data --//
        [Required]
        [StringLength(75, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
        public string Title { get; set; }
        [Required]
        [StringLength(400, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
        public string Description { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTimeOffset Created { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset? Updated { get; set; }
        
        //-- Navigation Properties --//
        public virtual BlogUser Author { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual BlogPostStatus BlogPostStatus { get; set; } 
    }
}
