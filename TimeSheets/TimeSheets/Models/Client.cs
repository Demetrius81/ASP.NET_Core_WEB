namespace TimeSheets.Models
{
    /// <summary>
    /// Информация о клиенте
    /// </summary>
    public class Client
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool IsDeleted { get; set; }

        public User User { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}
