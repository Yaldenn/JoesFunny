using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JoesFunny.Models;

namespace JoesFunny.Data
{
    public class JoesFunnyContext : DbContext
    {
        public JoesFunnyContext (DbContextOptions<JoesFunnyContext> options)
            : base(options)
        {
        }

        public DbSet<JoesFunny.Models.PersonalInformation> PersonalInformation { get; set; } = default!;
    }
}
