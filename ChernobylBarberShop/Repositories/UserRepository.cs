
using ChernobylBarberShop.Areas.Identity.Data;
using ChernobylBarberShop.Core.Repositories;

namespace ChernobylBarberShop.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ChernobylBarberShop_DbContext _context;

        public UserRepository(ChernobylBarberShop_DbContext context)
        {
            _context = context;
        }

        public ICollection<Chernobyl_User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public Chernobyl_User GetUser(string id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public Chernobyl_User UpdateUser(Chernobyl_User user)
        {
            _context.Update(user);
            _context.SaveChanges();

            return user;
        }
    }
}