using System.Collections.Generic;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Domain.Entities;
using TheKingdomSystem.Management.Domain.Interfaces;
using TheKingdomSystem.Management.Domain.Shared;

namespace TheKingdom.System.Management.Service
{
    public class UserService : IUserService
    {
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public UserService() { }

        private readonly IUserRepository _userRepository;
        public async Task<User> AlterUserId(User user)
        {
            var alterUser = await _userRepository.AlterUserId(user);
            if (alterUser != null)
                return alterUser;
            return null;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsers();
            if (users.Count != 0)
                return users;
            return null;
        }

        public async Task<User> GetUserById(int id)
        {
            var user = await _userRepository.GetUserById(id);
            return user;

        }

        public async Task<User> GetUserByLogin(string login)
        {
            var userLogin = await _userRepository.GetUserByLogin(login);
            if (userLogin != null)
                return userLogin;
            return null;
        }

        public Task<User> SaveUser(User user)
        {
            var hmacPassword = EncryptPassword(user.Password);
            user.Password = hmacPassword;
            var saveUserService = _userRepository.SaveUser(user);
            return saveUserService;
        }

        public async Task<bool> LoginUser(string login, string password)
        {
            var passwordEncrypt = EncryptPassword(password);
            var userDataBase = await _userRepository.GetUserByLogin(login);
            if (userDataBase.Password == passwordEncrypt && userDataBase.Login == login)
                return true;
            return false;
        }

        public string EncryptPassword(string password)
        {
            var encryptor = new Encryptor();
            var passwordEncrypt = encryptor.EncryptHmac256(password);
            return passwordEncrypt;
        }

        public async Task<User> DeleteUserId(int id)
        {
            var deleteUser = await _userRepository.DeleteUserId(id);
            return deleteUser;
        }
    }
}