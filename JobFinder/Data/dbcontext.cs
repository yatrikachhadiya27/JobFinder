using JobFinder.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Data
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> s) : base(s)
        {
        }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<CompanyModel> Companys { get; set; }

    }
}
