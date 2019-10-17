using Microsoft.EntityFrameworkCore;
using PaymentSchedule.Models;

namespace PaymentSchedule.Models
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext(DbContextOptions<WorkoutContext> options)
            : base(options)
        {
        }

       public DbSet<PaymentSchedule.Models.Vehicel> Vehicel { get; set; }
    }
}
