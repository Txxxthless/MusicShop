<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Domain.Entity;
using MusicShop.Domain.ViewModels;
using MusicShop.Service.Interfaces;
using System.Security.Claims;

namespace MusicShopApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                DataBaseResponse<ClaimsIdentity> response = await _accountService.Register(viewModel);

                if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
                {
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(response.Data));

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                DataBaseResponse<ClaimsIdentity> resposne = await _accountService.Login(viewModel);

                if(resposne.Status == MusicShop.Domain.Enum.StatusCode.OK)
                {
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(resposne.Data));

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(viewModel);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
=======
﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Domain.Entity;
using MusicShop.Domain.ViewModels;
using MusicShop.Service.Interfaces;
using System.Security.Claims;

namespace MusicShopApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                DataBaseResponse<ClaimsIdentity> response = await _accountService.Register(viewModel);

                if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
                {
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(response.Data));

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                DataBaseResponse<ClaimsIdentity> resposne = await _accountService.Login(viewModel);

                if(resposne.Status == MusicShop.Domain.Enum.StatusCode.OK)
                {
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(resposne.Data));

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(viewModel);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
