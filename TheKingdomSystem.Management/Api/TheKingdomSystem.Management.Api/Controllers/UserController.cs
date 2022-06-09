using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Domain.Entities;
using TheKingdomSystem.Management.Domain.Interfaces;

namespace TheKingdomSystem.Management.Api.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAllUsers")]//Ok
        public async Task<ActionResult<User>> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            if (users == null)
                return BadRequest("nenhum usuário localizado!");
            return Ok(users);           
        }

        [HttpGet("{idUser:int}", Name = "GetUserById")]//Ok
        public async Task<ActionResult<User>> GetUserById(int idUser)
        {            
            var getUserId = await _userService.GetUserById(idUser);
            if (getUserId != null)
                return Ok(getUserId);
            return BadRequest($"Não foi localizado usuário com o Id: {idUser}");
        }

        [HttpPost("LoginUser")]//OK
        public async Task<ActionResult<User>> LoginUser(string login, string password)
        {
            var loginUser = await _userService.LoginUser(login, password);
                if (loginUser == true)
                return Ok("Login liberado");
            return BadRequest("Usuário ou senha inválidos");
        }

        [HttpPost("SaveUser")]//OK
        public async Task<ActionResult<User>> SaveUser([FromBody] User user)
        {            
            var saveUser = await _userService.SaveUser(user);
            if(saveUser != null)
                return Ok(user);
            return BadRequest("Favor preencher o usuário corretamente");
        }

        [HttpPut("AlterUser")]//OK
        public async Task<ActionResult<User>> AlterUser([FromBody] User user)
        {
            var alterUser = await _userService.AlterUserId(user);

            if (alterUser == null)
                return BadRequest($"Não foi encontrado nenhum usuário com o Id: {user.Id}");
            return Ok(alterUser);
        }

        [HttpDelete("DeleteUserId")]//OK
        public async Task<ActionResult<User>> DeleteUserId(int id)
        {
            var deleteUserId = await _userService.DeleteUserId(id);
            if (deleteUserId.Id == id)
                return Ok(deleteUserId);
            return BadRequest("Favor informar id válido.");
        }
    }
}
