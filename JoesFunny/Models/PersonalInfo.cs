using System.ComponentModel.DataAnnotations;

namespace JoesFunny.Models;

public class PersonalInformation
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    public string SocialSecurityNumber { get; set; }
    public string address { get; set; }
}