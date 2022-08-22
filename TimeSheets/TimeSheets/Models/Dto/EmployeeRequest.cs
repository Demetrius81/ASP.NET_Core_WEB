using TimeSheets.Models.Dto.Interfaces;

namespace TimeSheets.Models.Dto
{
    public class EmployeeRequest : IRequest
    {
        public Guid UserId { get; set; }
    }
}
