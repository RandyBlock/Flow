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
        public DbSet<ClampOnMeasurement>? ClampOnMeasurements { get; set; }
        public DbSet<ClampOnVerification>? ClampOnVerifications { get; set; }
        public DbSet<DyeMeasurement>? DyeMeasurements { get; set; }
        public DbSet<DyeVerification>? DyeVerifications { get; set; }

        public DbSet<ManualMeasurement>? ManualMeasurements { get; set; }
        public DbSet<ManualVerification>? ManualVerifications { get; set; }
        public DbSet<Site>? Sites { get; set; }
        public DbSet<SiteVisit>? SiteVisits { get; set; }
        public DbSet<WorkOrder>? WorkOrders { get; set; }
        public DbSet<Verification>? Verifications { get; set; }
        public DbSet<VerificationMeasurement>? VerificationMeasurements { get; set; }




        public FlowDBContext(DbContextOptions options) : base(options) { }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DyeVerification>().OwnsOne(a => a.CalibrationUsed);
            modelBuilder.Entity<Site>().OwnsOne(a => a.Address);
            modelBuilder.Entity<SiteVisit>().OwnsOne(a => a.CheckList);

            base.OnModelCreating(modelBuilder);
        }
       
        

       
    }
}
 


       
       
        

 