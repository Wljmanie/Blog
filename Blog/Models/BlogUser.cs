using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class BlogUser : IdentityUser
    {
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}

        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
