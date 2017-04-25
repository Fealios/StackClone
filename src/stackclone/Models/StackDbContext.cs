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
    }

}
