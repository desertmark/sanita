using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Sanita.Models
{
    public class Context : DbContext
    {
         public Context()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Banner> Banners { get; set; }
    }
}