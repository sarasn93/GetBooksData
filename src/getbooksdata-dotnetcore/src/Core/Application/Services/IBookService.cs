using Core.Domain.Entities;
using System.Threading.Tasks;

namespace Core.Application.Services
{
    public interface IBookService
    {
        Task<BasicBookData> GetBook(string id);
        Task DeleteBook(string id);
    }
}
