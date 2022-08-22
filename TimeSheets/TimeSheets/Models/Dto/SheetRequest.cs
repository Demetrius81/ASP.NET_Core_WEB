using TimeSheets.Models.Dto.Interfaces;

namespace TimeSheets.Models.Dto
{
    public class SheetRequest : IRequest
    {
        public DateTime Date { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ContractId { get; set; }
        public Guid ServiceId { get; set; }
        public int Amount { get; set; }
    }
}
