using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartRent.Core.Models;
using SmartRent.Core.Services.Interfaces;

namespace SmartRent.Core.Services
{
    class UsersService : IUsersService
    {
        public void AssignManager(string managerId, int shopId)
        {
            throw new NotImplementedException();
        }

        public string CreateManager(User manager, string adminId)
        {
            throw new NotImplementedException();
        }

        public string EditManager(User manager, string adminId)
        {
            throw new NotImplementedException();
        }

        public string RemoveManager(string managerId, string adminId)
        {
            throw new NotImplementedException();
        }

        public void RemoveManagerFromShop(string managerId, int shopId)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
