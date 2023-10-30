using AutoMapper;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateUserCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _context.Users
               .FirstOrDefaultAsync(u => u.Id == request.Id, cancellationToken)
                   ?? throw new NotFoundException("Пользователь не найден!");

        _mapper.Map(request, user);
        
        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}