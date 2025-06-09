using GameScoreAPI.Application.Interfaces.Repositories;
using GameScoreAPI.Application.Interfaces.Repositories.EntityRepositories;
using GameScoreAPI.Persistence.Contexts;
using GameScoreAPI.Persistence.Repositories;
using GameScoreAPI.Persistence.Repositories.EntityRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameScoreAPI.Persistence.Extensions
{
    public static class PersistenceServiceRegistration
	{
		public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<GameScoreDbContext>(options =>
			options.UseNpgsql(configuration.GetConnectionString("PostgreSQL")));

			services.AddScoped(typeof(IReadRepository<>), typeof(GenericRepository<>));
			services.AddScoped(typeof(IWriteRepository<>), typeof(GenericRepository<>));
			services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
			services.AddScoped<IPlayerRepository, PlayerRepository>();
			services.AddScoped<IMatchRepository, MatchRepository>();

			return services;
		}
	}
}
