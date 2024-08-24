using System.ComponentModel.DataAnnotations;

namespace HeadlineHubWeb.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; } = string.Empty;

        //One to many realtionship
        public ICollection<Article> Articles { get; set; } = new List<Article>();


    }
}
