using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>().ToTable("T_FW_USER");
            builder.Entity<IdentityRole>().ToTable("T_FW_ROLE");
            builder.Entity<IdentityUserRole<string>>().ToTable("T_FW_USER_ROLE");
            builder.Entity<IdentityUserClaim<string>>().ToTable("T_FW_USER_CLAIM");
            builder.Entity<IdentityUserToken<string>>().ToTable("T_FW_USER_TOKEN");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("T_FW_ROLE_CLAIM");
            builder.Entity<IdentityUserLogin<string>>().ToTable("T_FW_USER_LOGIN");
        }
    }
}
