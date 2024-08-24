using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HeadlineHubWeb.Models
{
    public class Comment
    {
        
        public int CommentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CommentContent { get; set; } = string.Empty;

        [Required]
        public DateTime PostedDate { get; set; } = DateTime.UtcNow;

        public int ArticleId { get; set; }  // Foreign key
        public Article Article { get; set; }
    }
}
