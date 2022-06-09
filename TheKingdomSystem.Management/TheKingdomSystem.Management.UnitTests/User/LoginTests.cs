using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheKingdom.System.Management.Service;
using TheKingdomSystem.Management.Domain.Interfaces;
using TheKingdomSystem.Management.UnitTests.Mocks;

namespace TheKingdomSystem.Management.UnitTests.User
{
    [TestClass]
    public class LoginTests
    {
        private readonly IUserService _userService = new UserService(new FakeUserRepository());                      
        [TestMethod]
        public void ShoulbeReturnsTrueIfPasswordEqualsPasswordDatabaseTest()
        {
            // Arrange
            var encript = _userService.EncryptPassword("teste");
            var encriptDatabase = _userService.EncryptPassword("teste");
            // Act
            var result = LoginUserWhenPasswordAndLoginIsValid(encript, encriptDatabase);
            // Assert

            Assert.IsTrue(result);            
        }

        [TestMethod]
        public void ShoulbeReturnsFalseIfPasswordNotEqualsPasswordDatabaseTest()
        {
            // Arrange
            var encript = _userService.EncryptPassword("testando5");
            var databasePassword = _userService.EncryptPassword("testando");            
            // Act
            var result = LoginUserWhenPasswordAndLoginIsValid(databasePassword, encript);
            // Assert

            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void TestLoginAndPassword()
        {
            var loginUser = LoginUserWhenPasswordAndLoginIsValid("teste", "teste");          
            Assert.IsTrue(loginUser);
        }

        private bool LoginUserWhenPasswordAndLoginIsValid(string login, string password)
        {
            var loginTeste = _userService.GetUserByLogin(login);
            var passwordEntry = _userService.LoginUser(login, password);
            if (passwordEntry.IsCompleted == true)
                return true;
            return false;
        }        
    }
}
