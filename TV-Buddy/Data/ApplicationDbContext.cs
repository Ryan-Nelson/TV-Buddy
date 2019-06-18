using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TV_Buddy.Models;

namespace TV_Buddy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TV_Buddy.Models.ApplicationUser> ApplicationUser { get; set; }
        public DbSet<TV_Buddy.Models.Rooms> Rooms { get; set; }
        public DbSet<TV_Buddy.Models.TVS> TVS { get; set; }
        public DbSet<TV_Buddy.Models.TVSInRooms> TVSInRooms { get; set; }
    }
}
