using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Domain.Repository.Common;
using Core.Domain.Repository.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        private readonly ICommonContext _erpContext;

        public UserRepository(IMapper mapper,ICommonContext erpContext)
        {
            this._mapper = mapper;
            this._erpContext = erpContext;
        }

        public async Task<IEnumerable<UserDTO>> GetPaginatedUsers(PaginationParams paginationParams)
        {
            return await _erpContext.Users
                .ProjectTo<UserDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
