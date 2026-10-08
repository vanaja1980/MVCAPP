using System.ComponentModel.DataAnnotations;

namespace MyMVCApp.Model
{
    public class Category
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
    }
}
