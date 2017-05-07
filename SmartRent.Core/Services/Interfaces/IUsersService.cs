using SmartRent.Core.Models;

namespace SmartRent.Core.Services.Interfaces
{
    public interface IUsersService
    {
        string CreateManager(User manager, string adminId);

        string EditManager(User manager, string adminId);

        string RemoveManager(string managerId, string adminId);

        void AssignManager(string managerId, int shopId);

        void RemoveManagerFromShop(string managerId, int shopId);

        User GetUser(string userId);
    }
}
