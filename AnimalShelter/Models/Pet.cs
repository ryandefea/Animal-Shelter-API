using System.ComponentModel.DataAnnotations;
using System;
namespace AnimalShelter.Models
{
  public class Pet
  {
    public int PetId { get; set; }
    [Required]
    [StringLength(30)]
    public string Name { get; set; }
    [Required]

    public string Species { get; set; }
    [Required]
    [Range(0, 25, ErrorMessage = "Age must be between 0 and 200.")]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }

  }
}