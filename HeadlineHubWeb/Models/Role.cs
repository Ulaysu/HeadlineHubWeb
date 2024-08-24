using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HeadlineHubWeb.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; } = string.Empty;

        public ICollection<IdentityUserRole<int>> UserRoles { get; set; } 
            = new List<IdentityUserRole<int>>();
    }
}
