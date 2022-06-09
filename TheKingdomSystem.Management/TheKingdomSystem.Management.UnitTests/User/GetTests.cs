using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKingdom.System.Management.Service;
using TheKingdomSystem.Management.Domain.Interfaces;
using TheKingdomSystem.Management.UnitTests.Mocks;

namespace TheKingdomSystem.Management.UnitTests.User
{
    [TestClass]
    public class GetTests
    {
        private readonly IUserService _userService = new UserService(new FakeUserRepository());

        [TestMethod]
        public void GetAllUsersIfHaveUsersRegister()
        {
            var users = _userService.GetAllUsers();
            if (users.Result.Count != 0)
                Assert.IsTrue(users.IsCompletedSuccessfully);
        } 
        [TestMethod]
        public void GetUserById(int id)
        {
            var userId = _userService.GetUserById(1);
        }
    }
}
