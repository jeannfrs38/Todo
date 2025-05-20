using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Datas;

public class AppDbContext : DbContext
{
    public DbSet<TodoModel> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");

}