using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        //private readonly IDistributedCache _redisCache;

        //public BookRepository(IDistributedCache redisCache)
        //{
        //    _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        //}

        public Task DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetBook(int id)
        {
            throw new NotImplementedException();

            //var basket = await _redisCache.GetStringAsync(userName);

            //if (String.IsNullOrEmpty(basket))
            //    return null;

            //return JsonConvert.DeserializeObject<ShoppingCart>(basket);
        }
    }
}
