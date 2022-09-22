
using ChernobylBarberShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace ChernobylBarberShop.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}