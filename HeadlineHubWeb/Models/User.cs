using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeadlineHubWeb.Models
{
    public class User:IdentityUser<int>
    {

        public ICollection<Article> Articles { get; set; } = new List<Article>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        //ASP.NET Identity User Role 
        public ICollection<IdentityUserRole<int>> UserRoles { get; set; }
        public ICollection<IdentityUserClaim<int>> Claims { get; set;}
        public ICollection<IdentityUserLogin<int>> Logins { get; set;}
        public ICollection<IdentityUserToken<int>> Tokens { get; set;}

        public User()
        {
            UserRoles = new List<IdentityUserRole<int>>();
            Claims = new List<IdentityUserClaim<int>>();
            Logins = new List<IdentityUserLogin<int>>();
            Tokens = new List<IdentityUserToken<int>>();
            
        }

    }
}
