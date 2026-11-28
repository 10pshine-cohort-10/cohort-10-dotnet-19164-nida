using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class TaskStoreContext
    (DbContextOptions<TaskStoreContext> options) :
    DbContext(options)
    {


        public DbSet<TaskItem> taskItems => Set<TaskItem>();

        public DbSet<Category> categories => Set<Category>();

        public DbSet<ApplicationUser> applicationUsers => Set<ApplicationUser>();

        //configure r/s 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.User)
                .WithMany(u => u.TasksItems)
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId);
        }


    }
}