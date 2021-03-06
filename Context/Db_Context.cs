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

        public virtual DbSet<Procurement> Procurement { get; set; }
        public virtual DbSet<ProcurementPlus> ProcurementPlus { get; set; }
        public virtual DbSet<RoomNewModel> RoomNewModel { get; set; }
        public virtual DbSet<RoomreservationModel> RoomreservationModel { get; set; }
        public DbSet<BPMSysOUMembers> BPMSysOUMembers { get; set; }
        public DbSet<BPMSysOURoles> BPMSysOURoles { get; set; }
        public DbSet<BPMSysOUs> BPMSysOUs { get; set; }
        public DbSet<BPMInstProcSteps> BPMInstProcSteps { get; set; }
        public DbSet<BPMInstTasks> BPMInstTasks { get; set; }
        public DbSet<Reception> Reception { get; set; }
        public DbSet<Receptionplus> Receptionplus { get; set; }
        public DbSet<Receptions> Receptions { get; set; }
        public DbSet<Departure> Departure { get; set; }
        public virtual DbSet<AssetModel> AssetModel { get; set; }
        public virtual DbSet<AssetborrowModel> AssetborrowModel { get; set; }
        public virtual DbSet<AssetconnectModel> AssetconnectModel { get; set; }
        public virtual DbSet<HRModel> HRModel { get; set; }
        public virtual DbSet<AssetDaModel> AssetDaModel { get; set; }
        public virtual DbSet<AssetDtModel> AssetDtModel { get; set; }
        public virtual DbSet<AssetFdModel> AssetFdModel { get; set; }
        public virtual DbSet<CarMaintain> CarMaintain { get; set; }
        public virtual DbSet<CarInsurance> CarInsurance { get; set; }
        public virtual DbSet<CarService> CarService { get; set; }
        public virtual DbSet<CarBreak> CarBreak { get; set; }
        public virtual DbSet<Vehicel> Vehicel { get; set; }
    }

}
