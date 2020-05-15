using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class AppUserModel
    {
        public string Email { get; set; }
        public  string FullName { get; set; }
        public string  UserName { get; set; }
        public string Password { get; set; }
    }
}
