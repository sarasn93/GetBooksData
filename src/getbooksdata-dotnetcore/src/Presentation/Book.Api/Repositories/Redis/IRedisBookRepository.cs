using Book.Api.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book.Api.Repositories
{
    public interface IRedisBookRepository
    {
        Task<BasicBookData> GetBook(string id);
        Task AddBook(BasicBookData book);
        Task DeleteBook(string id);
    }
}
