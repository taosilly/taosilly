using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class ApplicationDbContext :DbContext
    {
       //  public ApplicationDbContext(){}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts{set;get;}
        public DbSet<Blog> Blogs{set;get;}
        public DbSet<Category> Categorys{set;get;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
             builder.Entity<Blog>().HasOne(rm=>rm.BlogCategory).WithMany(r=>r.Blogs).HasForeignKey(r=>r.CategoryId);

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public virtual int Commit()
        {
            return base.SaveChanges();
        }

        
    }

    public class AuditEntry
    {
        public int AuditEntryId { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
    }
}
