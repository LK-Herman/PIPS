using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PipsiProject.Models
{
        
    public class UserRole : IdentityRole<int>
    {
        public UserRole(): base()
        {
        }

        public UserRole(string roleName, string roleDesc) : base(roleName)
        {
            RoleDescription = roleDesc;
        }
                
        [Column(TypeName = "nvarchar(80)")]
        public string RoleDescription { get; set; }
    }
}
