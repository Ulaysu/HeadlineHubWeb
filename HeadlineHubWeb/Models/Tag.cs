using System.ComponentModel.DataAnnotations;

namespace HeadlineHubWeb.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        [Required]
        [MaxLength(50)]
        public string TagName { get; set; } = string.Empty;

        public List<Article> Articles { get; set; } = [];



    }
}
