using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PipsiProject.Models;

namespace PipsiProject.Models
{
    public class IdentityAppContext :IdentityDbContext<UserModel, UserRole, int>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
        {

        }
        public DbSet<PipsiProject.Models.UserModel> UserModel { get; set; }
    }
}
