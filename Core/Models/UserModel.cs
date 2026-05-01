namespace Core.Models;

public class UserModel
{
    public int _id { get; set; }

    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public string Role { get; set; } = null!;
    public string Department { get; set; } = null!;
    public string JobTitle { get; set; } = null!;

    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
}