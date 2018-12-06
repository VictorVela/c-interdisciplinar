using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ManageUsersViewModel
    {
        public IEnumerable<ApplicationUser> Administratores { get; set; }
        public IEnumerable<ApplicationUser> Everyone { get; set; }
    }
}
