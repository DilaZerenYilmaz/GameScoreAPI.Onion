using GameScoreAPI.Domain.Common;

namespace GameScoreAPI.Application.Interfaces.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : BaseEntity
    {
    }
}
