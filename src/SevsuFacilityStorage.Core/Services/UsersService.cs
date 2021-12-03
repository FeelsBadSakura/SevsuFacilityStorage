using Microsoft.AspNetCore.Identity;
using SevsuFacilityStorage.Abstractions;
using SevsuFacilityStorage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Services
{
    public class UsersService
    {
        private readonly IUsersRepository _usersRepository;

       private readonly RoleManager<IdentityRole> _roleManager;

       private readonly UserManager<IdentityUser> _userManager;

        public UsersService(IUsersRepository usersRepository, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _usersRepository = usersRepository;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task GetAllUsersAsync()
        {
            var allUsers = _usersRepository.GetAllUsers();
            List<UserViewModel> result = new List<UserViewModel>();
            foreach (var user in allUsers)
            {
                //var userRoles = await _userManager.GetRolesAsync(user);
                UserViewModel model = new UserViewModel
                {
                    Name = user.UserName,
                    //Role = userRoles.FirstOrDefault()
                };
                result.Add(model);
            }
        }

    }
}
