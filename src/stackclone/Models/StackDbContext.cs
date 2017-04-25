using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace stackclone.Models
{
    //public class StackDbContext : DbContext
    //{
    //    public StackDbContext()
    //    {

    //    }

    //}

    public class UserDbContext : IdentityDbContext<User>
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
