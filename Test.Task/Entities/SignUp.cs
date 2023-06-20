using System.ComponentModel.DataAnnotations;

namespace Test.Task.Entities;

public class SignUp
{
    public int Id { get; set; }
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public ERole Role { get; set; } = ERole.User;
}