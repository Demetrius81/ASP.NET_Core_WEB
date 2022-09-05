namespace TimeSheets.Models
{
    /// <summary>
    /// Информация о пользователе
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Company { get; set; }
        public int? Age { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Role { get; set; }

    }
}
