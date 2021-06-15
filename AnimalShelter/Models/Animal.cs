using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Category { get; set; }
    [Required]
    [Range(0, 5, ErrorMessage = "Age must be between 0 and 5.")]
    public int Intelligence { get; set; }
    [Required]
    public string Temperment { get; set; }
    [Required]
    public string Friendliness { get; set; }
    public string Ailment { get; set; }
  }
}