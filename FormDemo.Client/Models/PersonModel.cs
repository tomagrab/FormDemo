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
    [Required(ErrorMessage = "Life story is required")]
    [MinLength(10, ErrorMessage = "Life story must be at least 10 characters.")]
    [MaxLength(500, ErrorMessage = "Life story must be at most 500 characters.")]
    public string? LifeStory { get; set; }
    public bool IsEnrolled { get; set; }
    [Required(ErrorMessage = "Start Date is required")]
    public DateOnly StartDate { get; set; }
}
