using GameScoreAPI.Application.Interfaces.Repositories;
using GameScoreAPI.Domain.Common;
using GameScoreAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Persistence.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
	{
		private readonly GameScoreDbContext _dbContext;
		private readonly DbSet<T> _entities;

		public GenericRepository(GameScoreDbContext dbContext)
		{
			_dbContext = dbContext;
			_entities = _dbContext.Set<T>();
		}

		public async Task AddAsync(T entity)
		{
			await _entities.AddAsync(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(T entity)
		{
			 _entities.Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await _entities.ToListAsync();
		}

		public async Task<T> GetByIdAsync(Guid id)
		{
			return await _entities.FirstAsync(e => e.Id == id);
		}

		public async Task UpdateAsync(T entity)
		{
			_entities.Update(entity);
			await _dbContext.SaveChangesAsync();
		}
		public async Task SaveChangesAsync()
		{
			await _dbContext.SaveChangesAsync();
		}
	}
}
