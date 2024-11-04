using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    internal class IdentityService : IIdentityService
    {
        public Task<bool> AuthorizeAsync(string userId, string policyName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsInRoleAsync(string userId, string role)
        {
            throw new NotImplementedException();
        }
    }
}
