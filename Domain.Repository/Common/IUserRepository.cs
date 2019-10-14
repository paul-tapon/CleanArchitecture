using Core.Domain.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Repository.Common
{
    public class PaginationParams
    {
        int PageSize { get; set; }
        int PageNumber { get; set; }
        int SortDirection { get; set; }
        int SortColumn { get; set; }
    }



    public interface IUserRepository
    {
        Task<IEnumerable<UserDTO>> GetPaginatedUsers(PaginationParams paginationParams);
    }
}
