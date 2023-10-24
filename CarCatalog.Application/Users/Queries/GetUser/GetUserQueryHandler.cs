using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Users.Queries.GetUser;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserQueryViewModel>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetUserQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<UserQueryViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        return await _context.Users
                   .AsNoTracking()
                   .Where(u => u.Id == request.Id)
                   .ProjectTo<UserQueryViewModel>(_mapper.ConfigurationProvider)
                   .FirstOrDefaultAsync(cancellationToken)
               ?? throw new NotFoundException("Пользователь не найден!");
    }
}