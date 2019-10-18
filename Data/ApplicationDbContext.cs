using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Authpractice.Pages.Teams;
using Authpractice.Pages.Coach;

namespace Authpractice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Authpractice.Pages.Teams.teams> teams { get; set; }
        public DbSet<Authpractice.Pages.Coach.Coaches> Coaches { get; set; }
    }
}
