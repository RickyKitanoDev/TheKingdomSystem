using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Domain.Entities;

namespace TheKingdomSystem.Management.Domain.Interfaces
{
    public interface IUserService
    {
        Task<User> SaveUser(User user);
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> GetUserByLogin(string login);
        Task<User> AlterUserId(User user);
        Task<bool> LoginUser(string login, string password);
        string EncryptPassword(string password);
        Task<User> DeleteUserId(int id);
    }
}
