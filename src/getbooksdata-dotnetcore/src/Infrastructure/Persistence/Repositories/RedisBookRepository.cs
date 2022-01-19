using Core.Application.Repositories;
using Core.Domain.Entities;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RedisBookRepository : IRedisBookRepository
    {
        private readonly IDistributedCache _redisCache;

        public RedisBookRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        }

        public async Task AddBook(BasicBookData book)
        {
            await _redisCache.SetStringAsync(book.id, JsonConvert.SerializeObject(book));
        }

        public async Task DeleteBook(string id)
        {
            await _redisCache.RemoveAsync(id);
        }

        public async Task<BasicBookData> GetBook(string id)
        {

            var book = await _redisCache.GetStringAsync(id);

            if (String.IsNullOrEmpty(book))
                return null;

            return JsonConvert.DeserializeObject<BasicBookData>(book);
        }
    }
}
