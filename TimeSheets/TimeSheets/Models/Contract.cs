namespace TimeSheets.Models
{
    /// <summary>
    /// Информация о договоре с клиентом
    /// </summary>
    public class Contract
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public string Title { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Description { get; set; }
        
        public ICollection<Service> Services { get; set; }
        public ICollection<Sheet> Sheets { get; set; }
        public Client Client { get; set; }
    }
}
