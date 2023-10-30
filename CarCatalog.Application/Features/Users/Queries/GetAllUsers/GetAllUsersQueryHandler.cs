using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Application.Common.Pagination;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.Users.Queries.GetAllUsers;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, PaginatedList<GetAllUsersViewModel>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllUsersQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<GetAllUsersViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var query = _context.Users
            .AsNoTracking()
            .ProjectTo<GetAllUsersViewModel>(_mapper.ConfigurationProvider);

        return await PaginatedList<GetAllUsersViewModel>.CreateAsync(query, request.PageNumber, request.PageSize);
    }
}