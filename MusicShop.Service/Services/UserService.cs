
using Microsoft.EntityFrameworkCore;
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;

namespace MusicShop.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<DataBaseResponse<List<User>>> GetUsers()
        {
            DataBaseResponse<List<User>> response = new DataBaseResponse<List<User>>();
            try
            {
                List<User> users = await _userRepository.GetAll().ToListAsync();
                response.Data = users;
                response.Status = Domain.Enum.StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }
    }
}
