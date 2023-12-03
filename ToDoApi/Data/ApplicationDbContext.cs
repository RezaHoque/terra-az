using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSet<TEntity> is an implementation of IRepository<TEntity>
        public DbSet<TodoItem> ToDoItems { get; set; }
    }
}
