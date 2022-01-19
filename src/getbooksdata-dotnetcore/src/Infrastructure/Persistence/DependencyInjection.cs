
using Core.Application.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEasyCaching(options =>
            {
                options.UseInMemory("default");
            });
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString");
            });
            services.AddScoped<IRedisBookRepository, RedisBookRepository>();
            services.AddScoped<IInMemoryCacheRepository, InMemoryCacheRepository>();
        }
    }
}
