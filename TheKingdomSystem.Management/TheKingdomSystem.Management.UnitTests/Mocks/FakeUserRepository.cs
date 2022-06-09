using System.Collections.Generic;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Domain.Interfaces;
using TheKingdomSystem.Management.Domain.Entities;
using TheKingdomSystem.Management.Domain.Shared;

namespace TheKingdomSystem.Management.UnitTests.Mocks
{
    public class FakeUserRepository : IUserRepository
    {
        public Task<Domain.Entities.User> AlterUserId(Domain.Entities.User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<Domain.Entities.User> DeleteUserId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Domain.Entities.User>> GetAllUsers()
        {
            var users = new List<Domain.Entities.User>();
            var user1 = new Domain.Entities.User { Id = 1, Login = "teste", Password = "teste", Status = "Active" };
            var user2 = new Domain.Entities.User { Id = 2, Login = "teste", Password = "senhaTeste", Status = "Active" };
            users.Add(user1);
            users.Add(user2);            
            return Task.FromResult(users);            
        }

        public Task<Domain.Entities.User> GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Domain.Entities.User> GetUserByLogin(string login)
        {
            var user = new Domain.Entities.User() { Id = 1, Login = "teste", Password = new Encryptor().EncryptHmac256("teste"), Status = "Active" };
            if (user.Login == login)
                return Task.FromResult(user);
            return null;            
        }

        public Task<Domain.Entities.User> SaveUser(Domain.Entities.User user)
        {
            throw new System.NotImplementedException();
        }        
    }
}
