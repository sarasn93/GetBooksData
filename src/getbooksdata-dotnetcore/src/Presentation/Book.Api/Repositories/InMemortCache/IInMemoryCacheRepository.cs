using Book.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Api.Repositories.InMemortCache
{
    public interface IInMemoryCacheRepository
    {
        Task<BasicBookData> GetBook(string id);
        Task AddBook(BasicBookData book);
        Task DeleteBook(string id);
    }
}
