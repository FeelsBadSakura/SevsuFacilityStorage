using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SevsuFacilityStorage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(SignInManager<IdentityUser> signInManager,UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }


        [HttpPost]
        public async Task<IActionResult> LoginSystem(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            if (User?.Identity?.IsAuthenticated == true)
            {
                await _signInManager.SignOutAsync();
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (signInResult.IsNotAllowed)
            {
                Console.WriteLine("Bad");
                return Unauthorized();
            }

            if (signInResult.Succeeded)
            {
                return Redirect(model.ReturnUrl);
            }

            return StatusCode(500);
        }

        [HttpGet]
        public async Task<IActionResult> UserSignOut(string returnUrl)
        {
            await _signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }

        [HttpPost]

        public async Task<IActionResult> CreateUser(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser 
                { 
                    Email = model.Email, 
                    UserName = model.Email,
                    EmailConfirmed = true
                };


                var result = await _userManager.CreateAsync(user, model.Password);
                Console.WriteLine(result.Succeeded);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, model.RoleName);
                    return Ok();
                }
            }
            return StatusCode(500);
        }



    }
}
