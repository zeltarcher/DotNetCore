﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;

namespace MovieStoreMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = await _userService.Login(model);
            if (user == null)
            {
                throw new Exception("Invalid Login");
            }
            //cookies based authentication....
            return LocalRedirect("~/");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            //call the service and repository to hash the pass with salt and save to db
            var registerUser = await _userService.RegisterUser(model);
            return RedirectToAction("Login");
        }
    }
}
