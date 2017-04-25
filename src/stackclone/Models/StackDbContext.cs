using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace stackclone.Models
{
    public class StackDbContext : IdentityDbContext<User>
    {
        public StackDbContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StackClone;integrated security=True;");
        }
    }
}
