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
    [Range(0, 5, ErrorMessage = "Age must be between 0 and 5.")]
    public int Intelligence { get; set; }
    public string Temperment { get; set; }
    public string Friendliness { get; set; }
    public string Ailment { get; set; }
  }
}