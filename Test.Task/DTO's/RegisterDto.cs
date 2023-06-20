using Test.Task.Entities;

namespace Test.Task.DTO_s;

public class RegisterDto
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public ERole Role { get; set; }
}