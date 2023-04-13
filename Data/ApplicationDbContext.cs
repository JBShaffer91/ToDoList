using Microsoft.EntityFrameworkCore;
using TaskModel = ToDoList.Models.Task; // Add alias for your custom Task model

namespace ToDoList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Tasks = Set<TaskModel>(); // Initialize Tasks property with an empty DbSet
        }

        // Add your DbSet properties for the entities here
        public DbSet<TaskModel> Tasks { get; set; } // Use the TaskModel alias
    }
}
