using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoesFunny.Models;

public class PersonalInformation
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [Display(Name = "Date of birth")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    [Display(Name = "Social security number")]
    public string SocialSecurityNumber { get; set; }
    public string address { get; set; }
}