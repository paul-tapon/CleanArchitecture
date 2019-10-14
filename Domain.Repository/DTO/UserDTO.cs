using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Repository.DTO
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Organization { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
