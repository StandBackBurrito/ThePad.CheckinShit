using Ardalis.Specification.EntityFrameworkCore;
using ThePad.ChickenShit.SharedKernel.Interfaces;

namespace ThePad.ChickenShit.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
