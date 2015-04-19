using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class Unit
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Jednostka")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Minimalna wartość")]
        public int MinimalAmount { get; set; }
    }
}