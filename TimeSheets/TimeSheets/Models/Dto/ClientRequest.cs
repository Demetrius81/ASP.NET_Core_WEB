using TimeSheets.Models.Dto.Interfaces;

namespace TimeSheets.Models.Dto
{
    public class ClientRequest : IRequest
    {
        public Guid UserId { get; set; }
    }
}
