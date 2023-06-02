<<<<<<< HEAD
﻿
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
=======
﻿
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
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
