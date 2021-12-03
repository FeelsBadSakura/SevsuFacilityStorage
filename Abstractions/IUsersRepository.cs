using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Abstractions
{
    public interface IUsersRepository
    {
        public IEnumerable<IdentityUser> GetAllUsers();
    }
}
