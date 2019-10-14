using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Domain.Repository.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Application.Common.User.Queries.GetUsersList
{
    public class GetUsersListQuery : IRequest<UsersListVm>
    {

    }

    public class GetUsersListQueryHandler : IRequestHandler<GetUsersListQuery, UsersListVm>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public GetUsersListQueryHandler(IMapper mapper,IUserRepository userRepository)
        {
            _mapper = mapper;
            this._userRepository = userRepository;
        }

        public async Task<UsersListVm> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository
                                .GetPaginatedUsers(new PaginationParams());
            
            var vm = new UsersListVm
            {
                Users = users   
            };

            return vm;
        }
    }
}
