using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core.Domain.Repository.DTO;

namespace Core.Application.Common.User.Queries.GetUsersList
{
    public class UsersListVm
    {
        public IEnumerable<UserDTO> Users { get; set; }
    }
}
