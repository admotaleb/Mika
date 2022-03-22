using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mika.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mika.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TestImg> testImgs { get; set; }
        public DbSet<ImageModel> Images { get; set; }

    }
}
