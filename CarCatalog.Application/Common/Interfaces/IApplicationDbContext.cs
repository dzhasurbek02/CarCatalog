using CarCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<User> Users { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}