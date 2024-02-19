using FlavorWorld.Abstractions.BaseTypes;
using FlavorWorld.Domain.Abstractions.Common;
using FlavorWorld.Domain.BaseTypes;

namespace FlavorWorld.Abstractions.Repository.Product;

public interface IUserReadRepository<T, TId> : IReadReposiyory<T, TId>
    where T : Entity<TId>
    where TId : ValueObject
{

}
