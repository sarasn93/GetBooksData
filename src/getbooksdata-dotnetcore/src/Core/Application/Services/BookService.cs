using Core.Application.Repositories;
using Core.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Core.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IRedisBookRepository _redis;
        private readonly IInMemoryCacheRepository _cache;

        public BookService(IRedisBookRepository redis, IInMemoryCacheRepository cache)
        {
            _redis = redis ?? throw new ArgumentNullException(nameof(redis));
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
        }

        public async Task DeleteBook(string id)
        {
            await _cache.DeleteBook(id);
            await _redis.DeleteBook(id);
        }

        public async Task<BasicBookData> GetBook(string id)
        {
            var res = await _cache.GetBook(id);
            if (res == null)
            {
                res = await _redis.GetBook(id);
                if (res == null)
                {
                    Book1 apiBook = await GetBookDataFromTaaghche(id);
                    if (apiBook != null)
                    {

                        res = apiBook.book;
                        await _redis.AddBook(res);
                    }
                    else
                        return null;
                }
                await _cache.AddBook(res);
            }
            return res;
        }

        public async Task<Book1> GetBookDataFromTaaghche(string id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client
                    .GetAsync("https://get.taaghche.com/v2/book/" + id);
                if (Res.IsSuccessStatusCode)
                {
                    var bookFromApi = Res.Content.ReadAsStringAsync().Result;
                    var book = JsonConvert.DeserializeObject<Book1>(bookFromApi);
                    return book;
                }
                else
                    return null;
            }
        }

    }
}
