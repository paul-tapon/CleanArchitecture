using AutoMapper;
using Core.Domain.Model.Entities.Common;
using Core.Domain.Model.Entities.CSA;
using Core.Domain.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core.Application.Common.Mappings
{
   

    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Model.Entities.Common.User, UserDTO>()
                .ForMember(u => u.Username, opt => opt.MapFrom(t => t.Username))
                .ForMember(u => u.Organization, opt => opt.MapFrom(t => t.Organization.Name))
                .ForMember(u => u.CreatedOn, opt => opt.MapFrom(t => t.Created));


            CreateMap<Member, MemberDTO>()
               .ForMember(u => u.MemberId, opt => opt.MapFrom(t => t.MemberId))
               .ForMember(u => u.MemberNo, opt => opt.MapFrom(t => t.MemberNo));

            //ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
