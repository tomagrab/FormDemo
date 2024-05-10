using System.ComponentModel.DataAnnotations;

namespace FormDemo.Client.Models;

public class PersonModel
{
    [Required(ErrorMessage = "First name is required")]
    [MinLength(1, ErrorMessage = "First name must be at least 1 character.")]
    public string? FirstName { get; set; }
    [Required(ErrorMessage = "Last name is required")]
    [MinLength(1, ErrorMessage = "Last name must be at least 1 character.")]
    public string? LastName { get; set; }
}
