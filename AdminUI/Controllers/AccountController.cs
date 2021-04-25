using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminUI.Models;
using Business.Abstract;
using Entities.DTOs;

namespace AdminUI.Controllers
{
    public class AccountController:Controller
    {
        private IAuthService _authService;

        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                ModelState.AddModelError("", "Invalid login!");
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(userForLoginDto);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            return RedirectToAction("Login");
        }
    }
}
