using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication5.Models
{
    public class AppUser : IdentityUser
    {
        public static implicit operator AppUser(ApplicationUser v)
        {
            throw new NotImplementedException();
        }
    }
}