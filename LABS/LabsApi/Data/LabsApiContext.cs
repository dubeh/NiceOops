using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LabsApi.Modles;

namespace LabsApi.Data
{
    public class LabsApiContext : DbContext
    {
        public LabsApiContext (DbContextOptions<LabsApiContext> options)
            : base(options)
        {
        }

        public DbSet<LabsApi.Modles.Employee> Employee { get; set; } = default!;
    }
}
