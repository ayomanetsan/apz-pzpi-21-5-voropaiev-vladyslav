using Application.Features.Ponds.Queries.GetPondDataQuery;

namespace Application.Interfaces;

public interface IPondRepository : IRepository<Pond>
{
    Task<object> GetDataAsync(Guid pondId, CancellationToken cancellationToken);
}