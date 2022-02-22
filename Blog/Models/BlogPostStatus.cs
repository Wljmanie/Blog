using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class BlogPostStatus
    {
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
