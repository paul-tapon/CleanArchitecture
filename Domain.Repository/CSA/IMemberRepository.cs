using Core.Domain.Repository.Common;
using Core.Domain.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Repository.CSA
{
    public interface IMemberRepository
    {
        Task<IEnumerable<MemberDTO>> GetPaginatedMembers(PaginationParams paginationParams);

    }
}
