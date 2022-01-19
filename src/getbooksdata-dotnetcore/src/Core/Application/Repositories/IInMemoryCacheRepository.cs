using Core.Domain.Entities;
using System.Threading.Tasks;

namespace Core.Application.Repositories
{
    public interface IInMemoryCacheRepository
    {
        Task<BasicBookData> GetBook(string id);
        Task AddBook(BasicBookData book);
        Task DeleteBook(string id);
    }
}
