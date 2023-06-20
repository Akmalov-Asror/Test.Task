using System.ComponentModel.DataAnnotations;
using Test.Task.Entities;

namespace Test.Task.ViewModels;

public class SignUpUserViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Ismingizni kiritishingiz lozim!")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Familyangizni kiritishingiz lozim!")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email kiritishingiz lozim!")]
    [DataType(DataType.EmailAddress, ErrorMessage = "Email manzili noto'g'ri kiritildi.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Parol kiritishingiz lozim!")]
    public string Password { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public ERole Role { get; set; } = ERole.User;
}