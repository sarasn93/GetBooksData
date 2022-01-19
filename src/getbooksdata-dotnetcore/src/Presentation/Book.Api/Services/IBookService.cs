using Book.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Api.Services
{
    public interface IBookService
    {
        Task<BasicBookData> GetBook(string id);
        Task DeleteBook(string id);
    }
}
