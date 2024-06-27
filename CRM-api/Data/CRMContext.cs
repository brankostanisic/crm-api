using CRM_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM_api.Data
{
    public class CRMContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Project> Projects { get; set; }

        public CRMContext(DbContextOptions<CRMContext> options) : base(options) 
        {}
    }
}
