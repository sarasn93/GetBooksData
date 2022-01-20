using Core.Application.Repositories;
using Core.Application.Services;
using Core.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Book.ApiTest
{
    public class BookServiceFake : IBookService
    {
        private readonly List<BasicBookData> _books;

        private readonly IRedisBookRepository _redis;
        private readonly IInMemoryCacheRepository _cache;
        public BookServiceFake()
        {
            _books = new List<BasicBookData>()
            {
                new BasicBookData() { id = "545468", title="dlkjfdf", price=5477800,
                    description="jdfkdasfddfkdffkjdsfhdsjkbvihdfsvbirufhriegvireiguerngfouerjoimringut",
                    publisher="fdnvjfdjk", currencyPrice=55555, rating=3.5, numberOfPages=500,
                     type="2", beforeOffPrice=5555, canonicalId=2, coverUri="", currencyBeforeOffPrice=0
                , destination=10, encrypted=false, hasTemporaryOff=false, htmlDescription="",
                 ISBN="", isRtl=true , newsItemCreationDate=DateTime.Now, PhysicalPrice=55555, publishDate="1388/07/07"
                , PublisherID=250, publisherSlug="", refId="4" , shareText="" , shareUri="", showOverlay=false, sourceBookId=88,
                 state=2, subscriptionAvailable=false, labels=null},
                 new BasicBookData() { id = "110547", title="sara", price=5477800,
                    description="hello wooooooooooooooooorld",
                    publisher="jangal", currencyPrice=10000, rating=5, numberOfPages=680,
                     type="5", beforeOffPrice=1470000, canonicalId=2, coverUri="", currencyBeforeOffPrice=0
                , destination=10, encrypted=true, hasTemporaryOff=false, htmlDescription="",
                 ISBN="", isRtl=false , newsItemCreationDate=DateTime.Now, PhysicalPrice=9855550, publishDate="1388/07/07"
                , PublisherID=250, publisherSlug="", refId="4" , shareText="" , shareUri="", showOverlay=false, sourceBookId=88,
                 state=2, subscriptionAvailable=true, labels=null},

            };
        }

        public async Task DeleteBook(string id)
        {
            var delItem = _books.Where(m => m.id == id).FirstOrDefault();
            _books.Remove(delItem);
        }

        public async Task<BasicBookData> GetBook(string id)
        {
            var res = _books.Where(m => m.id == id).FirstOrDefault();
            if (res == null)
            {
                Book1 apiBook = await GetBookDataFromTaaghche(id);
                if (apiBook != null)
                {
                    res = apiBook.book;
                    _books.Add(res);
                }

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
