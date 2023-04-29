using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solution.Dtos.UserDtos;
using Solution.Models;
using System.Collections.Generic;
using Solution.Interfaces;

namespace Solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UsersController : ControllerBase
    {
        private readonly IUserApiRepo _repositoryUser;

        private readonly IMapper _mapper;

        public UsersController(IUserApiRepo repositoryUser, IMapper mapper)
        {
            _repositoryUser = repositoryUser;

            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreatedDto userCreatedDto)
        {
            var userModel = _mapper.Map<User>(userCreatedDto);

            await _repositoryUser.CreateUser(userModel);

            await _repositoryUser.SaveChangesAsync();

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return Created("", userModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _repositoryUser.GetAllUsers();

            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(users));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _repositoryUser.GetUserById(id);

            if(user == null)
                return NotFound();

            return Ok(_mapper.Map<UserReadDto>(user));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var userModelFromRepo = await _repositoryUser.GetUserById(id);

            if(userModelFromRepo == null)
                return NotFound();

            _repositoryUser.DeleteUser(userModelFromRepo);

            await _repositoryUser.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCommand(int id, UserUpdateDto updateDto)
        {
            var userModelFromRepo = await _repositoryUser.GetUserById(id);

            if(userModelFromRepo == null)
                return NotFound();

            _mapper.Map(updateDto, userModelFromRepo);

            await _repositoryUser.UpdateUser(userModelFromRepo);

            await _repositoryUser.SaveChangesAsync();

            return NoContent();
        }
    }
}