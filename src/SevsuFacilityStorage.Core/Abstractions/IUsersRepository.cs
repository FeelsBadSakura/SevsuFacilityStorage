using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SevsuFacilityStorage.Abstractions
{
    public interface IUsersRepository
    {
        public IEnumerable<IdentityUser> GetAllUsers();
    }
}
