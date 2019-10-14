using AutoMapper;
using Core.Domain.Repository.Common;
using Core.Domain.Repository.CSA;
using Core.Domain.Repository.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Application.CSA.Member.Queries.GetMemberList
{
    public class GetMemberListQuery : IRequest<MemberListVm>
    {
    }

    public class MemberListVm
    {
        public IEnumerable<MemberDTO> Members { get; set; }
    }

    public class GetMemberListQueryHandler : IRequestHandler<GetMemberListQuery, MemberListVm>
    {
        private readonly IMemberRepository _memberRepository;

        public GetMemberListQueryHandler(IMemberRepository memberRepository)
        {
            this._memberRepository = memberRepository;
        }

        public async Task<MemberListVm> Handle(GetMemberListQuery request, CancellationToken cancellationToken)
        {
            var members = await _memberRepository
                                .GetPaginatedMembers(new PaginationParams());

            var vm = new MemberListVm
            {
                Members = members
            };

            return vm;
        }
    }
}
