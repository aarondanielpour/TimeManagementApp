using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TimeManagementApp.Models;

namespace TimeManagementApp.Data
{
    public class TimeManagementAppContext : DbContext
    {
        public TimeManagementAppContext (DbContextOptions<TimeManagementAppContext> options)
            : base(options)
        {
        }

        public DbSet<TimeManagementApp.Models.TaskItem> TaskItem { get; set; } = default!;
    }
}
