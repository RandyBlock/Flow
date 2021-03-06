using Flow.WPF.Models;
using Microsoft.EntityFrameworkCore;


namespace Flow
{
    public class FlowDBContext : DbContext
    {
        
        public DbSet<Address>? Adresses { get; set; }
        public DbSet<BathMeasurement>? BathMeasurements { get; set; }
        public DbSet<Calibration>? Calibrations { get; set; }
        public DbSet<CheckList>? CheckLists { get; set; }
        public DbSet<ClampOn>? ClampOns { get; set; }
        public DbSet<ClampOnConfirmationMeasurement>? ClampOnConfirmationMeasurements { get; set; }
        public DbSet<DyeConfirmationMeasurement>? DyeConfirmationMeasurements { get; set; }
        public DbSet<ManualConfirmationMeasurement>? ManualConfirmationMeasurements { get; set; }

        public DbSet<Dye>? Dyes { get; set; }
        public DbSet<Manual>? Manuals { get; set; }
        public DbSet<Site>? Sites { get; set; }
        public DbSet<SiteVisit>? SiteVisits { get; set; }
        public DbSet<WorkOrder>? WorkOrders { get; set; }




        public FlowDBContext(DbContextOptions options) : base(options) { }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dye>().OwnsOne(a => a.CalibrationUsed);
            modelBuilder.Entity<Site>().OwnsOne(a => a.Address);
            modelBuilder.Entity<SiteVisit>().OwnsOne(a => a.CheckList);

            base.OnModelCreating(modelBuilder);
        }
       
        

       
    }
}
 


       
       
        

 