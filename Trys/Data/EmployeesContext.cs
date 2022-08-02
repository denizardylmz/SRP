using Microsoft.EntityFrameworkCore;
using Trys.Models;

namespace Trys.Data;

public class EmployeesContext : DbContext
{
    
    public DbSet<Personal> Personals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Employees.db");
    }
}