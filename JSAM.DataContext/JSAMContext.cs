using JSAM.Classes;
using System.Data.Entity;

namespace JSAM.DataContext
{
    public class JSAMContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
    }
}
