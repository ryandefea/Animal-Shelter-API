using System.ComponentModel.DataAnnotations;
using System;
namespace AnimalShelter.Models
{
  public class Pet
  {
    public int PetId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

  }
}