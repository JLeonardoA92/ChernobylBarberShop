using ChernobylBarberShop.Areas.Identity.Data;

namespace ChernobylBarberShop.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<Chernobyl_User> GetUsers();

        Chernobyl_User GetUser(string id);

        Chernobyl_User UpdateUser(Chernobyl_User user);
    }
}