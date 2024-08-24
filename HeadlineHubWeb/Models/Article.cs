using System.ComponentModel.DataAnnotations;

namespace HeadlineHubWeb.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime PublishedDate { get; set; }

        [Required]
        public DateTime LastModifiedDate { get; set;}

        //Navigation
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Tag> Tags { get; set; } = [];
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public int UserId { get; set; }
        public User User { get; set; }



    }
}
