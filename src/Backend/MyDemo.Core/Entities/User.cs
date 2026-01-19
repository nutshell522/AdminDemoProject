namespace MyDemo.Core;

public class User
{
  public Guid Id { get; set; }
  public required string UserName { get; set; }
  public required string PasswordHash { get; set; }
  public string? Role { get; set; }
  public DateTime CreatedAt { get; set; }
}
