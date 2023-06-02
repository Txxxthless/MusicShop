<<<<<<< HEAD
﻿
using Microsoft.EntityFrameworkCore;
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;
using MusicShop.Domain.Helpers;
using MusicShop.Domain.ViewModels;
using MusicShop.Service.Interfaces;
using System.ComponentModel.Design.Serialization;
using System.Security.Claims;

namespace MusicShop.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Basket> _basketRepository;
        private readonly IRepository<Order> _orderRepository;
        public AccountService(IRepository<User> userRepository, 
            IRepository<Basket> basketRepository, 
            IRepository<Order> orderRepository)
        {
            _userRepository = userRepository;
            _basketRepository = basketRepository;
            _orderRepository = orderRepository;
        }

        public async Task<DataBaseResponse<ClaimsIdentity>> Login(LoginViewModel viewModel)
        {
            try
            {
                DataBaseResponse<ClaimsIdentity> response = new DataBaseResponse<ClaimsIdentity>();
                User user = await _userRepository.GetAll().FirstOrDefaultAsync(user => user.Name == viewModel.Name);

                if (user == null)
                {
                    response.Description = "Incorrect name or password!";
                    return response;
                }

                if (user.Password != PasswordHelper.HashPassword(viewModel.Password))
                {
                    response.Description = "Incorrect name or password!";
                    return response;
                }

                ClaimsIdentity result = Authenticate(user);
                response.Data = result;
                response.Status = Domain.Enum.StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                return new DataBaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    Status = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public async Task<DataBaseResponse<ClaimsIdentity>> Register(RegisterViewModel viewModel)
        {
            try
            {
                DataBaseResponse<ClaimsIdentity> response = new DataBaseResponse<ClaimsIdentity>();
                User user = _userRepository.GetAll().FirstOrDefault(user => user.Name == viewModel.Name);

                if (user != null)
                {
                    response.Description = "User alredy exists";
                    response.Status = Domain.Enum.StatusCode.UserAlreadyExists;
                    return response;
                }

                user = new User()
                {
                    Name = viewModel.Name,
                    Password = PasswordHelper.HashPassword(viewModel.Password),
                    Role = Domain.Enum.Role.User
                };

                await _userRepository.Create(user);

                Basket basket = new Basket()
                {
                    UserId = user.Id
                };

                await _basketRepository.Create(basket);

                ClaimsIdentity result = Authenticate(user);

                response.Data = result;
                response.Status = Domain.Enum.StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                return new DataBaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    Status = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        private ClaimsIdentity Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };
            return new ClaimsIdentity(claims, "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
=======
﻿
using Microsoft.EntityFrameworkCore;
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;
using MusicShop.Domain.Helpers;
using MusicShop.Domain.ViewModels;
using MusicShop.Service.Interfaces;
using System.ComponentModel.Design.Serialization;
using System.Security.Claims;

namespace MusicShop.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Basket> _basketRepository;
        private readonly IRepository<Order> _orderRepository;
        public AccountService(IRepository<User> userRepository, 
            IRepository<Basket> basketRepository, 
            IRepository<Order> orderRepository)
        {
            _userRepository = userRepository;
            _basketRepository = basketRepository;
            _orderRepository = orderRepository;
        }

        public async Task<DataBaseResponse<ClaimsIdentity>> Login(LoginViewModel viewModel)
        {
            try
            {
                DataBaseResponse<ClaimsIdentity> response = new DataBaseResponse<ClaimsIdentity>();
                User user = await _userRepository.GetAll().FirstOrDefaultAsync(user => user.Name == viewModel.Name);

                if (user == null)
                {
                    response.Description = "Incorrect name or password!";
                    return response;
                }

                if (user.Password != PasswordHelper.HashPassword(viewModel.Password))
                {
                    response.Description = "Incorrect name or password!";
                    return response;
                }

                ClaimsIdentity result = Authenticate(user);
                response.Data = result;
                response.Status = Domain.Enum.StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                return new DataBaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    Status = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public async Task<DataBaseResponse<ClaimsIdentity>> Register(RegisterViewModel viewModel)
        {
            try
            {
                DataBaseResponse<ClaimsIdentity> response = new DataBaseResponse<ClaimsIdentity>();
                User user = _userRepository.GetAll().FirstOrDefault(user => user.Name == viewModel.Name);

                if (user != null)
                {
                    response.Description = "User alredy exists";
                    response.Status = Domain.Enum.StatusCode.UserAlreadyExists;
                    return response;
                }

                user = new User()
                {
                    Name = viewModel.Name,
                    Password = PasswordHelper.HashPassword(viewModel.Password),
                    Role = Domain.Enum.Role.User
                };

                await _userRepository.Create(user);

                Basket basket = new Basket()
                {
                    UserId = user.Id
                };

                await _basketRepository.Create(basket);

                ClaimsIdentity result = Authenticate(user);

                response.Data = result;
                response.Status = Domain.Enum.StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                return new DataBaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    Status = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        private ClaimsIdentity Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };
            return new ClaimsIdentity(claims, "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
