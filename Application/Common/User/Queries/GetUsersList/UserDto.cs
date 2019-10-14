using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core.Application.Common.Mappings;
using Core.Domain.Model.Entities.Common;

namespace Core.Application.Common.User.Queries.GetUsersList
{
    //public class UserDto : IMapFrom<User>
    //{
    //    public string Username { get; set; }
    //    public string Organization { get; set; }
    //    public DateTime CreatedOn { get; set; }

    //    public void Mapping(Profile profile)
    //    {
    //        profile.CreateMap<User, UserDto>()
    //            .ForMember(u => u.Username, opt => opt.MapFrom(t => t.Username))
    //            .ForMember(u => u.Organization, opt => opt.MapFrom(t => t.Organization.Name))
    //            .ForMember(u => u.CreatedOn, opt => opt.MapFrom(t => t.Created));

    //    }
    //}
}
