﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GameScoreAPI.Application.Extensions
{
	public static class ApplicationServiceRegistration
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			return services;
		}
	}
}
