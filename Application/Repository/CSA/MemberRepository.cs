using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Domain.Repository.Common;
using Core.Domain.Repository.CSA;
using Core.Domain.Repository.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Repository.CSA
{
    public class MemberRepository : IMemberRepository
    {
        private readonly IMapper _mapper;
        private readonly ICSAContext _csaContext;

        public MemberRepository(IMapper mapper, ICSAContext csaContext)
        {
            this._mapper = mapper;
            this._csaContext = csaContext;
        }

        public async Task<IEnumerable<MemberDTO>> GetPaginatedMembers(PaginationParams paginationParams)
        {
            return await _csaContext.Members
              .ProjectTo<MemberDTO>(_mapper.ConfigurationProvider)
              .ToListAsync();
        }

        
    }

   
}
