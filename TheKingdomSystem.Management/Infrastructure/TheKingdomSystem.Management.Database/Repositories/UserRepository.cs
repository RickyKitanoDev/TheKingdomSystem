using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Database.DatabaseContext;
using TheKingdomSystem.Management.Domain.Entities;
using TheKingdomSystem.Management.Domain.Interfaces;
using TheKingdomSystem.Management.Domain.Shared;

namespace TheKingdomSystem.Management.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(ManagementDataContext context)
        {
            _context = context;
        }

        private readonly ManagementDataContext _context;        

        public async Task<List<User>> GetAllUsers()
        {
            var users = _context.User.Include(p => p.Employee).ToList();
            return await Task.FromResult(users);
        }

        public async Task<User> GetUserById(int id)
        {

            var user = await _context.User.AsNoTracking().FirstOrDefaultAsync(user => user.Id == id);

            if (user != null)
                return user;
            return null;

            // select Login from Users where Login = 'Ricky';            
        }

        public async Task<User> SaveUser(User user)
        {
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetUserByLogin(string login)
        {
            var user = await _context.User.AsNoTracking().FirstOrDefaultAsync(u => u.Login == login);

            if (user != null)
                return user;
            return null;
        }

        public async Task<User> AlterUserId(User user)
        {
            var userDataBase = await GetUserById(user.Id);
            if (userDataBase == null)
                return null;
            userDataBase.Login = user.Login;
            userDataBase.Password = new Encryptor().EncryptHmac256(user.Password);
            userDataBase.Employee = user.Employee;
            userDataBase.Status = user.Status;
            _context.Entry<User>(userDataBase).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            //_context.Update<User>(userDataBase);
            //await _context.SaveChangesAsync();
            return userDataBase;
        }

        public async Task<User> DeleteUserId(int id)
        {
            var deleteUser = await _context.User.FirstOrDefaultAsync(u => u.Id == id);
            if (deleteUser.Id == id)
            { 
                 _context.Remove(deleteUser);
                await _context.SaveChangesAsync();
                return deleteUser;
            }
            return null;
        }
    }
}
