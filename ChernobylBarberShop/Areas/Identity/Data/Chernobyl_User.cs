using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ChernobylBarberShop.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Chernobyl_User class
public class Chernobyl_User : IdentityUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

