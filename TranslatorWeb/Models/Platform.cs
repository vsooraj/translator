using System.ComponentModel.DataAnnotations;

namespace TranslatorWeb.Models
{
    public class Platform
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsActive { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }
    }
}