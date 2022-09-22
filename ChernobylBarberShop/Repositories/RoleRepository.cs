
using ChernobylBarberShop.Areas.Identity.Data;
using ChernobylBarberShop.Core.Repositories;
using Microsoft.AspNetCore.Identity;

namespace ChernobylBarberShop.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ChernobylBarberShop_DbContext _context;

        public RoleRepository(ChernobylBarberShop_DbContext context)
        {
            _context = context;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}