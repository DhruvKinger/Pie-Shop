using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseApplication.Auth;
using Microsoft.AspNetCore.Identity;

namespace EnterpriseApplication.Models
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<FeedBack> feedBacks { get; set; }
    }
}
