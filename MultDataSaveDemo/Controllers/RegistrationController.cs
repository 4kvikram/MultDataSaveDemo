using Microsoft.AspNetCore.Mvc;

using MultDataSaveDemo.Interface;
using MultDataSaveDemo.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MultDataSaveDemo.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IUserService _userService;

        public RegistrationController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult RegisterUser()
        {
            ViewBag.CityList = _userService.GetAllCity();
            return View();
        }
        [HttpGet]
        public IActionResult SaveRegisterUser(string data)
        {
            var model = JsonSerializer.Deserialize<List<RegistrationViewModel>>(data);
            if (ModelState.IsValid)
            {
                //   Request.con
                var res = _userService.RegistrationBulk(model);

            }
            return Ok();// RedirectToAction(nameof(GetRegistration));
        }

        [HttpGet]
        public IActionResult GetRegistration()
        {
            var res = _userService.GetRegration();
            return View(res);
        }

        [HttpGet]
        public IActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCity(CityViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.AddCity(model);
            }
            return RedirectToAction(nameof(RegisterUser));
        }

        [HttpPost]
        public IActionResult GetCity(CityViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.AddCity(model);
            }
            return View();
        }
    }
}
