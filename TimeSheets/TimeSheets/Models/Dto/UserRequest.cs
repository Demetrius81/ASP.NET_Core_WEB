using TimeSheets.Models.Dto.Interfaces;

namespace TimeSheets.Models.Dto
{
    public class UserRequest : IRequest
    {
        public string UserName { get; set; }
    }
}
