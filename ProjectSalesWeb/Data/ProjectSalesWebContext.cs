using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSalesWeb.Models;

namespace ProjectSalesWeb.Data
{
    public class ProjectSalesWebContext : DbContext
    {
        public ProjectSalesWebContext (DbContextOptions<ProjectSalesWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectSalesWeb.Models.Department> Department { get; set; }
    }
}
