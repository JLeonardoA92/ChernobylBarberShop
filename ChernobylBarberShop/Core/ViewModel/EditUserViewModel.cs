
using ChernobylBarberShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ChernobylBarberShop.Core.ViewModels
{
    public class EditUserViewModel
    {
        public Chernobyl_User User { get; set; }

        public IList<SelectListItem> Roles { get; set; }
    }
}