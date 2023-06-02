
using MusicShop.Domain.Entity;
using MusicShop.Domain.ViewModels;
using System.Security.Claims;

namespace MusicShop.Service.Interfaces
{
    public interface IAccountService
    {
        Task<DataBaseResponse<ClaimsIdentity>> Register(RegisterViewModel viewModel);
        Task<DataBaseResponse<ClaimsIdentity>> Login(LoginViewModel viewModel);
    }
}
