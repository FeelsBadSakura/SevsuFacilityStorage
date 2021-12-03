using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SevsuFacilityStorage.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Data
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationDbContext _context;

        public UsersRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<IdentityUser> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
