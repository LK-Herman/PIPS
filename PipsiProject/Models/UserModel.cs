using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PipsiProject.Models
{
    public class UserModel: IdentityUser<int>
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }


    }
}
