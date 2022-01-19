using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetBook(int id);
        Task DeleteBook(int id);
    }
}
