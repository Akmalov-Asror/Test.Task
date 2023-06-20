using System.ComponentModel.DataAnnotations;

namespace Test.Task.ViewModels;

public class SignInUserViewModel
{
    [Required]
    public string UserName { get; set; }
    public string Password { get; set; }
}