using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow
{
    public class FlowDBContextFactory : IDesignTimeDbContextFactory<FlowDBContext>
    {
        public FlowDBContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<FlowDBContext>();

            options.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=FlowDB;Trusted_Connection=True;");

            return new FlowDBContext(options.Options);  
        }
    }
}
