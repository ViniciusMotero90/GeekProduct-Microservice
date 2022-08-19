using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.IdentityServer.Model
{
    public class ApplicationUser : IdentityUser
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
    }
}