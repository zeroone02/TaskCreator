using Microsoft.EntityFrameworkCore;
using TaskCreator.DDD;
using TaskCreator.Domain;

namespace DotnetWorld.TaskCreator.EntityFrameworkCore;
public class TaskCreatorDbContext : DbContext, IEfCoreDbContext
{
   public TaskCreatorDbContext(DbContextOptions<TaskCreatorDbContext> options )
        : base(options)
    {

    }
    public DbSet<MainTask> MainTasks { get; set; }
    public DbSet<SideTask> SideTasks { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MainTask>().Property(x => x.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<SideTask>().Property(x => x.Id).ValueGeneratedOnAdd();
    }
}
