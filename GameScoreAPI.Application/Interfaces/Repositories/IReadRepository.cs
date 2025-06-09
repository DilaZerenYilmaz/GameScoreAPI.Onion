using GameScoreAPI.Domain.Common;

namespace GameScoreAPI.Application.Interfaces.Repositories
{
    public interface IReadRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<List<T>> GetAllAsync();
    }
}
