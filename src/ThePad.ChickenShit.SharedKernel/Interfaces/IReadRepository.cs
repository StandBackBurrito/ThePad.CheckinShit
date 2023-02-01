using Ardalis.Specification;

namespace ThePad.ChickenShit.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
