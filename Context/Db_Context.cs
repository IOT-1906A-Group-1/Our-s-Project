using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Db_Context: DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = 10.3.187.19,1433;Initial Catalog = BPMDB;User ID = sa; Password = 123;");
            }
        }
        public DbSet<User> User { get; set; }
        public DbSet<Leave> Leave { get; set; }
        public DbSet<PlanModels> PlanModels { get; set; }
        public DbSet<InfoModels> InfoModels { get; set; }
        public virtual DbSet<Employ> Employ { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<BPMSysUsers> BPMSysUsers { get; set; }
        public virtual DbSet<ChapterModels> ChapterModels { get; set; }
        public virtual DbSet<AssetModel> AssetModel { get; set; }
    }
}
