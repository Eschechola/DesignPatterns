using System.Threading.Tasks;
using MediatorPattern.Data.Entities;

namespace MediatorPattern.Data.Repository
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> GetById(long id);
        Task<User> GetByEmail(string email);
    }
}
