namespace HomeTaskScheduler.Application.DTO.Users;

public class CreateUserDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string AvatarUrl { get; set; }
    public string PreferedLanguage { get; set; }
    public string Username { get; set; }
}