using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class AppDataContext : IdentityDbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> opt) : base(opt)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
