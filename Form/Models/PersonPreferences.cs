using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Form.Models;

public class PersonPreferences
{
    [Required(ErrorMessage = "Please enter your name.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Please enter your last name.")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "Please choose country.")]
    [Display(Name = "Country")]
    public string SelectedCountry { get; set; }
    public List<string> Countries { get; set; } = ["USA", "Canada", "UK"];
    
    [Display(Name = "Subscribe to newsletter agreement")]
    public bool SubscribeToNewsletter { get; set; }
    [Required(ErrorMessage = "Please choose your gender.")]
    public string Gender { get; set; }
}