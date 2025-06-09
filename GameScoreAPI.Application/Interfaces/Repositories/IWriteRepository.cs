using GameScoreAPI.Domain.Common;

namespace GameScoreAPI.Application.Interfaces.Repositories
{
    public interface IWriteRepository<in T> where T : BaseEntity
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task SaveChangesAsync();

	}
}
