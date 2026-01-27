using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo_app.Model;

namespace Demo_app.Data
{
    public class Demo_appContext : DbContext
    {
        public Demo_appContext (DbContextOptions<Demo_appContext> options)
            : base(options)
        {
        }

        public DbSet<Demo_app.Model.Student> Student { get; set; } = default!;
    }
}
