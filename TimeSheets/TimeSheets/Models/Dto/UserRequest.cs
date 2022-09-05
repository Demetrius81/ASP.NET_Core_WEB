﻿using TimeSheets.Models.Dto.Interfaces;

namespace TimeSheets.Models.Dto
{
    public class UserRequest : IRequest
    {        
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
