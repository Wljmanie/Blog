using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Blog
    {
        //-- Keys --//
        public int Id { get; set; }
        public string CreatorId { get; set; }
        public int BlogStatusId { get; set; }

        //-- Data --//
        [Required]
        [StringLength(75, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
        public string Title { get; set; }
        [Required]
        [StringLength(400, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTimeOffset Created { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset? Updated { get; set; }

        //-- Navigation Properties --//
        public virtual BlogUser Creator { get; set; }
        public virtual BlogStatus BlogStatus { get; set; }
        public virtual ICollection<BlogPost> Posts { get; set; }
    }
}
